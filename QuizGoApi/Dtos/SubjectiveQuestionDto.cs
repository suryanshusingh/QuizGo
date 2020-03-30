using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGoApi.Dtos
{
    public class SubjectiveQuestionDto : QuestionsToReturnDto
    {
        public int SubjectiveId { get; set; }
    }
}
