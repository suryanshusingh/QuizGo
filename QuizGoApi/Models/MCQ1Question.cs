using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizGoApi.Dtos;

namespace QuizGoApi.Models
{
    public class MCQ1Question : MCQQuestion
    {
        public string CorrectOption { get; set; }
        public override string CorrectAnswer()
        {
            return CorrectOption;
        }

        public override QuestionsToReturnDto Map(int id)
        {
            return new MCQ1QuestionDto()
            {
                QuestionType = "MCQ1",
                MCQ1Id = Id,
                QuestionNumber = id,
                QuestionText = QuestionText,
                OptionA = OptionA,
                OptionB = OptionB,
                OptionC = OptionC,
                OptionD = OptionD
            };
        }
    }
}
