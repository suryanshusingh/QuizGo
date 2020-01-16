using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.Dtos
{
    class MCQ2QuestionDto
    {
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public bool IsOptionAChecked { get; set; }
        public bool IsOptionBChecked { get; set; }
        public bool IsOptionCChecked { get; set; }
        public bool IsOptionDChecked { get; set; }
        public string QuestionNumberAndText
        {
            get
            {
                return QuestionNumber.ToString() + ". " + QuestionText;
            }
        }
    }
}
