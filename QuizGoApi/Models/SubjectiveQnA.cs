using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGoApi.Models
{
    public class SubjectiveQnA : SubjectiveQuestion
    {
        public string AnswerByUser { get; set; }
    }
}
