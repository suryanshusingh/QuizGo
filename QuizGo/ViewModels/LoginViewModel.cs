using QuizGo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        public event Action<bool> LoggedIn;
        private IQuizRepository quizRepository;
        public RelayCommand LoginCommand { get; private set; }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; 
            OnPropertyChange("Username");}
        }

        public LoginViewModel(IQuizRepository quizRepository)
        {
            this.quizRepository = quizRepository;
            LoginCommand = new RelayCommand(OnClickLogin);
        }

        private void OnClickLogin()
        {
            // check for username
            if (quizRepository.CheckUserExists(Username))
                LoggedIn(true);
        }
    }
}
