using QuizGo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.ViewModels
{
    class SubmitViewModel : BaseViewModel
    {
        private DateTime todayDate = DateTime.Now;
        private int score;
        private string result;
        public RelayCommand ExitCommand { get; private set; }

        public string Result
        {
            get 
            {
                if (score > 50)
                {
                    return "Pass";
                }
                else return "Fail";
            }
            set 
            {
                if (score > 50)
                {
                    result = "Pass";
                }
                else result = "Fail";
                OnPropertyChange("Result"); 
            }
        }


        public int Score
        {
            get { return score; }
            set { score = value; OnPropertyChange("Score"); }
        }

        public DateTime TodayDate
        {
            get { return todayDate; }
            set
            { todayDate = value;
                OnPropertyChange("TodayDate");
            }
        }

        public SubmitViewModel(IQuizRepository quizRepository, int score)
        {
            this.quizRepository = quizRepository;
            this.score = score;
            ExitCommand = new RelayCommand(OnExitClick);
        }

        private void OnExitClick()
        {
            System.Windows.Application.Current.Shutdown();
        }

        public IQuizRepository quizRepository { get; private set; }
    }
}
