using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizGoApi.Data;
using QuizGoApi.Dtos;

namespace QuizGoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private IQuizRepository repo;
        public QuizController(IQuizRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<QuestionDto>> GetQuestions()
        {
            var a = await repo.GetQuestions();
            return a;
        }
    }
}