using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizGoApi.Data;
using QuizGoApi.Dtos;
using QuizGoApi.Helpers;
using QuizGoApi.Models;

namespace QuizGoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class QuizController : ControllerBase
    {
        private readonly IQuizRepository repo;
        public QuizController(IQuizRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet("questions")]
        public async Task<IActionResult> GetQuestions()
        {
            var questions = await repo.GetQuestions();
            
            //map question to questiondto
            var questionsToReturn = Mapper.Map(questions);

            return Ok(questionsToReturn);
        }
    }
}