using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.Dtos
{
    class MCQ1QuestionDto
    {
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string AnswerByUser { get; set; }
        public string QuestionNumberAndText
        {
            get
            {
                return QuestionNumber.ToString() + ". " + QuestionText;
            }
        }
    }
}
