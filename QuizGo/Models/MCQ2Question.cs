using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.Models
{
    class MCQ2Question : MCQQuestion
    {
        public bool IsACorrect { get; set; }
        public bool IsBCorrect { get; set; }
        public bool IsCCorrect { get; set; }
        public bool IsDCorrect { get; set; }
    }
}
