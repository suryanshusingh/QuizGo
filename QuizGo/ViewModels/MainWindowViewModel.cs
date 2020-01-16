using QuizGo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        private IQuizRepository quizRepository = new QuizRepository();
        private bool isLoggedIn;
        private bool isNotLoggedIn;
        private QuestionViewModel questionViewModel;
        private bool isSubmit;
        private SubmitViewModel submitViewModel;

        public SubmitViewModel SubmitViewModel
        {
            get { return submitViewModel; }
            set
            {
                submitViewModel = value;
                OnPropertyChange("SubmitViewModel");
            }
        }


        public LoginViewModel LoginViewModel { get; set; }

        public QuestionViewModel QuestionViewModel
        {
            get => questionViewModel;
            set
            {
                questionViewModel = value;
                OnPropertyChange("QuestionViewModel");
            }
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set
            {
                isLoggedIn = value;
                OnPropertyChange("IsLoggedIn");
            }
        }

        public bool IsNotLoggedIn
        {
            get
            {
                return isNotLoggedIn;
            }
            set
            {
                isNotLoggedIn = value;
                OnPropertyChange("IsNotLoggedIn");
            }
        }
        public bool IsSubmit
        {
            get
            {
                return isSubmit;
            }
            set
            {
                isSubmit = value;
                OnPropertyChange("IsSubmit");
            }
        }

        public MainWindowViewModel()
        {
            IsLoggedIn = false;
            IsNotLoggedIn = true;
            LoginViewModel = new LoginViewModel(quizRepository);
            LoginViewModel.LoggedIn += OnLoggedIn;
        }

        public void OnLoggedIn(bool isLoggedIn)
        {
            IsLoggedIn = isLoggedIn;
            IsNotLoggedIn = !isLoggedIn;
            QuestionViewModel = new QuestionViewModel(quizRepository);
            QuestionViewModel.SubmitClick += OnSubmitClick;
        }

        private void OnSubmitClick(bool submitvisible, int score)
        {
            IsLoggedIn = !submitvisible;
            IsNotLoggedIn = !submitvisible;
            IsSubmit = submitvisible;
            SubmitViewModel = new SubmitViewModel(quizRepository, score);

        }
    }
}
