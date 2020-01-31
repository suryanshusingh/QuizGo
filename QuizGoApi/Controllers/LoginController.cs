using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizGoApi.Data;
using QuizGoApi.Dtos;
using QuizGoApi.Models;

namespace QuizGoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthRepository repo;
        public LoginController(IAuthRepository repo)
        {
            this.repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserForLoginDto user)
        {
            var userFromRepo = await repo.Login(user.Username.ToLower(), user.Email.ToLower());

            if (userFromRepo == false)
                return Unauthorized();
            return Ok();
        }

    }
}