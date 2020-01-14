using QuizGo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.Data
{
    class DBDataContext : DbContext
    {
        public DBDataContext() : base("QuizGODB")
        {

        }

        public DbSet<SubjectiveQuestion> SubjectiveQuestions { get; set; }
        public DbSet<MCQ1Question> MCQ1Questions { get; set; }
        public DbSet<MCQ2Question> MCQ2Questions { get; set; }

    }
}
