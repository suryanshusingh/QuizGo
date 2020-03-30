using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGoApi.Dtos
{
    public class MCQ1QuestionDto : QuestionsToReturnDto
    {
        public int MCQ1Id { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
    }
}
