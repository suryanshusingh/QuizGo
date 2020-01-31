using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGoApi.Data
{
    public interface IAuthRepository
    {
        bool CheckUserExists(string username);
        Task<bool> Login(string username, string email);
    }
}
