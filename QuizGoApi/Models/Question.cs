using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizGoApi.Dtos;

namespace QuizGoApi.Models
{
    public abstract class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public abstract string CorrectAnswer();
        public abstract QuestionsToReturnDto Map(int id);
    }
}
