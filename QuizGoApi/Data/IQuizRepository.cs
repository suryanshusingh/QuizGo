using QuizGoApi.Dtos;
using QuizGoApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGoApi.Data
{
    public interface IQuizRepository
    {
        Task<ObservableCollection<QuestionDto>> GetQuestions();

        int CalculateScore(ObservableCollection<QuestionDto> questionswithanswers);
    }
}
