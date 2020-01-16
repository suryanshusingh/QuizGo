using QuizGo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.Data
{
    interface IQuizRepository
    {
        bool CheckUserExists(string username);
        ObservableCollection<object> GetQuestions();

        int CalculateScore(ObservableCollection<object> questionswithanswers);
    }
}
