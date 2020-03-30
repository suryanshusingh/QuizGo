using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using QuizGoApi.Data;
using QuizGoApi.Dtos;
using QuizGoApi.Helpers;
using QuizGoApi.Models;

namespace QuizGoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthRepository repo;
        private readonly IConfiguration config;
        public LoginController(IAuthRepository repo, IConfiguration config)
        {
            this.repo = repo;
            this.config = config;
        }

        #region HttpPosts
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto user)
        {
            var userFromRepo = await repo.Login(user.Email.ToLower(), user.Password.ToLower());

            if (userFromRepo == null)
                return Unauthorized();

            var userToReturn = Mapper.MapUserToReturn(userFromRepo);

            string token = GetJwtToken(userFromRepo);

            return Ok(new
            {
                token,
                userToReturn
            });
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            if (await repo.CheckEmailExistsAsync(userForRegisterDto.Email.ToLower()))
                return BadRequest("Email already exists");

            var user = MapUserTo(userForRegisterDto);

            var registeredUser = await repo.Register(user, userForRegisterDto.Password);

            var userToReturn = MapUserToReturnTo(registeredUser);

            return Ok(userToReturn);
        }
        #endregion

        #region PrivateMethods
        private string GetJwtToken(User userFromRepo)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
                new Claim(ClaimTypes.Name, userFromRepo.UserName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);
            return token;
        }
        private UserToReturnDto MapUserToReturnTo(User registeredUser)
        {
            return new UserToReturnDto
            {
                Username = registeredUser.UserName,
                Email = registeredUser.Email,
                Gender = registeredUser.Gender,
                Id = registeredUser.Id
            };
        }
        private User MapUserTo(UserForRegisterDto userForRegisterDto)
        {
            return new User{ UserName = userForRegisterDto.Username,
                Created = DateTime.Now,
            Email = userForRegisterDto.Email,
            Gender = userForRegisterDto.Gender
            };
        }
        #endregion
    }
}