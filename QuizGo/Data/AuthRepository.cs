using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DBDataContext context;
        public AuthRepository()
        {
            context = new DBDataContext();
        }
        public bool CheckUserExists(string username)
        {
            var users = context.Users.ToList();
            var user = context.Users.FirstOrDefault(x => x.Username == username);
            if (user != null)
                return true;
            return false;
        }
    }
}
