using QuizGo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.Data
{
    class QuizRepository : IQuizRepository
    {
        private readonly DBDataContext context;

        public QuizRepository()
        {
            context = new DBDataContext();
        }

        public int CalculateScore()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Question> GetQuestions()
        {
            ObservableCollection<Question> questions = new ObservableCollection<Question>();
            
            var subjectiveQuestions = context.SubjectiveQuestions.OrderBy(r => Guid.NewGuid()).Take(2) ;
            foreach (var question in subjectiveQuestions) questions.Add(question);

            var mcq1Questions = context.MCQ1Questions.OrderBy(r => Guid.NewGuid()).Take(5);
            foreach (var question in mcq1Questions) questions.Add(question);

            var mcq2Questions = context.MCQ2Questions.OrderBy(r => Guid.NewGuid()).Take(3);
            foreach (var question in mcq2Questions) questions.Add(question);

            return questions;
        }

        private void AddData()
        {
            var a = new List<SubjectiveQuestion>();
            a.Add(new SubjectiveQuestion
            {
                QuestionText = "What is the national bird of India?",
                AnswerText = "Peacock"
            });
            a.Add(new SubjectiveQuestion
            {
                QuestionText = "How many months do we have in a year?",
                AnswerText = "12"
            });
            a.Add(new SubjectiveQuestion
            {
                QuestionText = "What is 2+2?",
                AnswerText = "4"
            });
            a.Add(new SubjectiveQuestion
            {
                QuestionText = "How many colors in a rainbow?",
                AnswerText = "7"
            }); a.Add(new SubjectiveQuestion
            {
                QuestionText = "Which is the smallest planet?",
                AnswerText = "Mercury"
            });
            a.Add(new SubjectiveQuestion
            {
                QuestionText = "What is the name of planet we live?",
                AnswerText = "Earth"
            });
            foreach (var i in a) context.SubjectiveQuestions.Add(i);
            context.SaveChanges();
        }
        private void AddMCQData()
        {
            var a = new List<MCQ1Question>();
            a.Add(new MCQ1Question
            {
                QuestionText = "What is square root of 144?",
                OptionA = "10",
                OptionB = "11",
                OptionC = "12",
                OptionD = "13",
                CorrectOption = "C"
            });
            a.Add(new MCQ1Question
            {
                QuestionText = "Which is the biggest animal?",
                OptionA = "Whale",
                OptionB = "Elephant",
                OptionC = "Ant",
                OptionD = "Hippo",
                CorrectOption = "A"
            });
            a.Add(new MCQ1Question
            {
                QuestionText = "Who is CEO of Siemens AG?",
                OptionA = "Roland Busch",
                OptionB = "Joe Kaeser",
                OptionC = "Ralf Thomas",
                OptionD = "Klaus Trecher",
                CorrectOption = "B"
            });
            a.Add(new MCQ1Question
            {
                QuestionText = "Who is founder of Siemens?",
                OptionA = "Ernst Werner Siemens",
                OptionB = "Johann Georg Siemens",
                OptionC = "Werner Von Siemens",
                OptionD = "Ferdinand Siemens",
                CorrectOption = "C"
            });
            a.Add(new MCQ1Question
            {
                QuestionText = "What is cube root of 1000?",
                OptionA = "10",
                OptionB = "11",
                OptionC = "12",
                OptionD = "13",
                CorrectOption = "A"
            });
            a.Add(new MCQ1Question
            {
                QuestionText = "What is name of Prestige Building?",
                OptionA = "Salarpuria",
                OptionB = "MindSpace",
                OptionC = "EcoZone",
                OptionD = "Alecto",
                CorrectOption = "D"
            });
            a.Add(new MCQ1Question
            {
                QuestionText = "What is full form of HI?",
                OptionA = "Hearing Instrument",
                OptionB = "Hard Instrument",
                OptionC = "Hearing Insta",
                OptionD = "Heard Instrument",
                CorrectOption = "A"
            });
            foreach (var i in a) context.MCQ1Questions.Add(i);
            context.SaveChanges();
        }
        private void AddMCQ2Data()
        {
            var a = new List<MCQ2Question>();
            a.Add(new MCQ2Question
            {
                QuestionText = "What is square root of 225?",
                OptionA = "15",
                OptionB = "14",
                OptionC = "14.0",
                OptionD = "15.0",
                IsACorrect = true,
                IsBCorrect = false,
                IsCCorrect = false,
                IsDCorrect = true
            });
            a.Add(new MCQ2Question
            {
                QuestionText = "Which of these are birds?",
                OptionA = "Cat",
                OptionB = "Parrot",
                OptionC = "Owl",
                OptionD = "Mushroom",
                IsACorrect = false,
                IsBCorrect = true,
                IsCCorrect = true,
                IsDCorrect = false
            });
            a.Add(new MCQ2Question
            {
                QuestionText = "In which countries is Siemens office located?",
                OptionA = "India",
                OptionB = "Japan",
                OptionC = "USA",
                OptionD = "Germany",
                IsACorrect = true,
                IsBCorrect = true,
                IsCCorrect = true,
                IsDCorrect = true
            });
            a.Add(new MCQ2Question
            {
                QuestionText = "In which cities is Siemens Office located?",
                OptionA = "Bangalore",
                OptionB = "Noida",
                OptionC = "Pune",
                OptionD = "Chennai",
                IsACorrect = true,
                IsBCorrect = true,
                IsCCorrect = true,
                IsDCorrect = true
            });
            //a.Add(new MCQ2Question
            //{
            //    QuestionText = "What is square root of 225?",
            //    OptionA = "15",
            //    OptionB = "14",
            //    OptionC = "14.0",
            //    OptionD = "15.0",
            //    IsACorrect = true,
            //    IsBCorrect = false,
            //    IsCCorrect = false,
            //    IsDCorrect = true
            //});
            //a.Add(new MCQ2Question
            //{
            //    QuestionText = "What is square root of 225?",
            //    OptionA = "15",
            //    OptionB = "14",
            //    OptionC = "14.0",
            //    OptionD = "15.0",
            //    IsACorrect = true,
            //    IsBCorrect = false,
            //    IsCCorrect = false,
            //    IsDCorrect = true
            //});
            //a.Add(new MCQ2Question
            //{
            //    QuestionText = "What is square root of 225?",
            //    OptionA = "15",
            //    OptionB = "14",
            //    OptionC = "14.0",
            //    OptionD = "15.0",
            //    IsACorrect = true,
            //    IsBCorrect = false,
            //    IsCCorrect = false,
            //    IsDCorrect = true
            //});
            foreach (var i in a) context.MCQ2Questions.Add(i);
            context.SaveChanges();
        }
    }
}
