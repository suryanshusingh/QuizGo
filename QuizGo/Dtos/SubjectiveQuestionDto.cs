using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.Dtos
{
    class SubjectiveQuestionDto
    {
        
        public string QuestionText { get; set; }
        public string AnswerByUser { get; set; }
        public int QuestionNumber { get; set; }
        public string QuestionNumberAndText
        {
            get
            {
                return QuestionNumber.ToString() + ". " + QuestionText; 
            }
        }
    }
}
