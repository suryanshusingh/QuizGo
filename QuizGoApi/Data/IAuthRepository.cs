using QuizGoApi.Dtos;
using QuizGoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGoApi.Data
{
    public interface IAuthRepository
    {
        Task<bool> CheckEmailExistsAsync(string email);
        Task<User> Login(string email, string password);
        Task<User> Register(User user, string password);
    }
}
