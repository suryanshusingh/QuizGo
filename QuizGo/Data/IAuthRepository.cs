using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.Data
{
    interface IAuthRepository
    {
        bool CheckUserExists(string username);
    }
}
