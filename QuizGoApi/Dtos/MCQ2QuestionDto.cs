using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGoApi.Dtos
{
    public class MCQ2QuestionDto : QuestionDto
    {
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public bool IsOptionAChecked { get; set; }
        public bool IsOptionBChecked { get; set; }
        public bool IsOptionCChecked { get; set; }
        public bool IsOptionDChecked { get; set; }
    }
}
