using QuizGo.Data;
using QuizGo.Dtos;
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
        private object currentQuestion;
        public ObservableCollection<object> Questions { get; set; } = new ObservableCollection<object>();
        private IQuizRepository quizRepository;
        public RelayCommand PreviousCommand { get; private set; }
        public RelayCommand NextCommand { get; private set; }
        public RelayCommand SkipCommand { get; private set; }
        public RelayCommand SubmitCommand { get; private set; }
        public RelayCommand ReviewCommand { get; private set; }
        private int currentQuestionNumber;
        private int[] touched = new int[10];

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
            set
            {
                timeRemaining = value;
                OnPropertyChange("TimeRemaining");
            }
        }

        public object CurrentQuestion
        {
            get => currentQuestion;
            set
            {
                currentQuestion = value;
                OnPropertyChange("CurrentQuestion");
            }
        }

        public int[] Touched
        {
            get
            {
                return touched;
            }
            set
            {
                touched = value;
                OnPropertyChange("Touched");
            }
        }

        public string CurrentMCQChoice { get; set; }

        public QuestionViewModel(IQuizRepository quizRepository)
        {
            StartTimer();
            CommandsInstantiation();
            this.quizRepository = quizRepository;
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

            if (Questions[currentQuestionNumber - 1] is MCQ2QuestionDto)
            {
                var queswithanswer = Questions[currentQuestionNumber - 1] as MCQ2QuestionDto;
                queswithanswer.IsOptionAChecked = queswithanswer.IsOptionBChecked = 
                    queswithanswer.IsOptionCChecked = queswithanswer.IsOptionDChecked = false;
            }
            else
            {
                var queswithanswer = Questions[currentQuestionNumber - 1] as MCQ1QuestionDto;
                if (queswithanswer != null) queswithanswer.AnswerByUser = string.Empty;
                var subjques = Questions[currentQuestionNumber - 1] as SubjectiveQuestionDto;
                if (subjques != null) subjques.AnswerByUser = string.Empty;
            }
            CurrentQuestionNumber += 1;
        }

        private void OnReviewClick()
        {
            throw new NotImplementedException();
        }

        private void OnSubmitClick()
        {
            int score = quizRepository.CalculateScore(Questions);
        }

        private void OnNextClick()
        {
            if (CurrentQuestionNumber == 10) return;

            CurrentQuestionNumber += 1;
        }

        private void OnPreviousClick()
        {
            if (CurrentQuestionNumber == 1) return;
            CurrentQuestionNumber -= 1;
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
