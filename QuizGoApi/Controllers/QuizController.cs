using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizGoApi.Data;

namespace QuizGoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private IAuthRepository repo;
        public QuizController(IAuthRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public void CheckUserExistsGet()
        {
            var a = 5;
        }
    }
}