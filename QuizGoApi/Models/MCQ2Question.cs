using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizGoApi.Dtos;

namespace QuizGoApi.Models
{
    public class MCQ2Question : MCQQuestion
    {
        public bool IsACorrect { get; set; }
        public bool IsBCorrect { get; set; }
        public bool IsCCorrect { get; set; }
        public bool IsDCorrect { get; set; }
        public override string CorrectAnswer()
        {
            string mcq2Answer = string.Empty;
            mcq2Answer += IsACorrect == true ? '1' : '0';
            mcq2Answer += IsBCorrect == true ? '1' : '0';
            mcq2Answer += IsCCorrect == true ? '1' : '0';
            mcq2Answer += IsDCorrect == true ? '1' : '0';
            return mcq2Answer;
        }

        public override QuestionsToReturnDto Map(int id)
        {
            return new MCQ2QuestionDto()
            {
                QuestionType = "MCQ2",
                MCQ2Id = Id,
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
