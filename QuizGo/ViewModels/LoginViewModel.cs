using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.ViewModels
{
    class LoginViewModel
    {
        public RelayCommand LoginCommand { get; private set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(OnClickLogin);
        }

        private void OnClickLogin()
        {
            // check for username

            //navigate to new page
        }
    }
}
