using QuizGo.Data;
using QuizGo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace QuizGo.ViewModels
{
    class QuestionViewModel : BaseViewModel
    {
        TimeSpan time = new TimeSpan(0, 30, 0);
        DispatcherTimer timer;
        private string timeRemaining;
        private Question currentQuestion;
        public ObservableCollection<Question> Questions { get; set; } = new ObservableCollection<Question>();
        private IQuizRepository quizRepository = new QuizRepository();
        public RelayCommand PreviousCommand { get; private set; }
        public RelayCommand NextCommand { get; private set; }
        public RelayCommand SkipCommand { get; private set; }
        public RelayCommand SubmitCommand { get; private set; }
        public RelayCommand ReviewCommand { get; private set; }
        private int currentQuestionNumber;

        public int CurrentQuestionNumber
        {
            get => currentQuestionNumber;
            set
            {
                currentQuestionNumber = value;
                OnPropertyChange("CurrentQuestionNumber");
                CurrentQuestion = Questions[currentQuestionNumber - 1];
            }
        }


        public string TimeRemaining
        {
            get { return timeRemaining; }
            set { 
                timeRemaining = value;
                OnPropertyChange("TimeRemaining");
            }
        }

        public Question CurrentQuestion
        {
            get => currentQuestion;
            set
            {
                currentQuestion = value;
                OnPropertyChange("CurrentQuestion");
            }
        }


        public QuestionViewModel()
        {
            StartTimer();
            CommandsInstantiation();
            Questions = quizRepository.GetQuestions();
            CurrentQuestionNumber = 1;
        }

        private void CommandsInstantiation()
        {
            PreviousCommand = new RelayCommand(OnPreviousClick);
            NextCommand = new RelayCommand(OnNextClick);
            SkipCommand = new RelayCommand(OnSkipClick);
            ReviewCommand = new RelayCommand(OnReviewClick);
            SubmitCommand = new RelayCommand(OnSubmitClick);
        }

        private void OnSkipClick()
        {
            if (CurrentQuestionNumber == 10) return;
            CurrentQuestionNumber += 1;
        }

        private void OnReviewClick()
        {
            throw new NotImplementedException();
        }

        private void OnSubmitClick()
        {
            throw new NotImplementedException();
        }

        private void OnNextClick()
        {
            if (CurrentQuestionNumber == 10) return;
            CurrentQuestionNumber += 1 ;
            //CurrentQuestion = Questions[currentQuestionNumber-1];
        }

        private void OnPreviousClick()
        {
            if (CurrentQuestionNumber == 1) return;
            CurrentQuestionNumber -= 1 ;
        }

        private void StartTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            time = time.Subtract(new TimeSpan(0, 0, 1));
            TimeRemaining = time.ToString();
        }
    }
}
