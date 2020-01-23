using QuizGo.Dtos;
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
        ObservableCollection<QuestionDto> GetQuestions();

        int CalculateScore(ObservableCollection<QuestionDto> questionswithanswers);
    }
}
