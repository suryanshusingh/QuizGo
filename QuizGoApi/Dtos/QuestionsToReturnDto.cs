using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGoApi.Dtos
{
    public class QuestionsToReturnDto
    {
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
    }
}
