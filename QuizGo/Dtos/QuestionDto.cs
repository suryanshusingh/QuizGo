using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.Dtos
{
    class QuestionDto
    {
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public string QuestionNumberAndText
        {
            get
            {
                return QuestionNumber.ToString() + ". " + QuestionText;
            }
        }
    }
}
