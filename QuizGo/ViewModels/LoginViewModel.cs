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
        private IAuthRepository authRepository;
        public RelayCommand LoginCommand { get; private set; }
        private string username;
        private bool displayErrorMessage;

        public bool DisplayErrorMessage
        {
            get { return displayErrorMessage; }
            set { displayErrorMessage = value;
                OnPropertyChange("DisplayErrorMessage");
            }
        }

        public string Username
        {
            get { return username; }
            set { username = value; 
            OnPropertyChange("Username");}
        }

        public LoginViewModel(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
            LoginCommand = new RelayCommand(OnClickLogin);
        }

        private void OnClickLogin()
        {
            // check for username
            if (authRepository.CheckUserExists(Username))
            {
                DisplayErrorMessage = false;
                LoggedIn(true);
            }
            else
            {
                DisplayErrorMessage = true;
            }
        }
    }
}
