using Microsoft.EntityFrameworkCore;
using QuizGoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGoApi.Data
{
    public class DBDataContext : DbContext
    {
        public DBDataContext(DbContextOptions<DBDataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<SubjectiveQuestion> SubjectiveQuestions { get; set; }
        public DbSet<MCQ1Question> MCQ1Questions { get; set; }
        public DbSet<MCQ2Question> MCQ2Questions { get; set; }

    }
}
