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
        public bool CheckUserExists(string username)
        {
            var users = context.Users.ToList();
            var user = context.Users.FirstOrDefault(x => x.Username == username);
            if (user != null)
                return true;
            return false;
        }

        public async Task<bool> Login(string username, string email)
        {
            var users = await context.Users.ToListAsync();
            var user = context.Users.FirstOrDefault(x => x.Username == username && x.Email == email);
            if (user != null)
                return true;
            return false;
        }

        private void AddUsers()
        {
            var a = new List<User>();
            a.Add(new User
            {
                Username = "suryanshu",
                Email = "singhsuryanshu@gmail.com"
            });
            a.Add(new User
            {
                Username = "surya",
                Email = "abc@gmail.com"
            });

            foreach (var i in a) context.Users.Add(i);
            context.SaveChanges();
        }
    }
}
