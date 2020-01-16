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
        public RelayCommand LoginCommand { get; private set; }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; 
            OnPropertyChange("Username");}
        }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(OnClickLogin);
        }

        private void OnClickLogin()
        {
            // check for username

            //navigate to new page
            LoggedIn(true);
        }
    }
}
