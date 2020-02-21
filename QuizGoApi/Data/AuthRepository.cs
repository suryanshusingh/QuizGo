using Microsoft.EntityFrameworkCore;
using QuizGoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGoApi.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DBDataContext context;
        public AuthRepository(DBDataContext context)
        {
            this.context = context;
        }
        public async Task<bool> CheckEmailExistsAsync(string email)
        {
            var users = context.Users.ToList();
            var user = await context.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user != null)
                return true;
            return false;
        }
        public async Task<User> Register(User user, string password)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<User> Login(string email, string password)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Email == email);
            
            if (user == null)
                return null;
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }
            return user;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                        return false;
                }
            }
            return true;
        }

        private void AddUsers()
        {
            var a = new List<User>();
            a.Add(new User
            {
                UserName = "suryanshu",
                Email = "singhsuryanshu@gmail.com"
            });
            a.Add(new User
            {
                UserName = "surya",
                Email = "abc@gmail.com"
            });

            foreach (var i in a) context.Users.Add(i);
            context.SaveChanges();
        }
    }
}
