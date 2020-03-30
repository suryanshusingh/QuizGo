using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizGoApi.Dtos;

namespace QuizGoApi.Models
{
    public class SubjectiveQuestion : Question
    {
        public string AnswerText { get; set; }
        public override string CorrectAnswer()
        {
            return AnswerText;
        }

        public override QuestionsToReturnDto Map(int id)
        {
            return new SubjectiveQuestionDto()
            {
                QuestionType = "Subjective",
                SubjectiveId = Id,
                QuestionNumber = id,
                QuestionText = QuestionText
            };
        }
    }
}
