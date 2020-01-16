using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGo.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
		private bool isLoggedIn;
		private bool isNotLoggedIn;
		private QuestionViewModel questionViewModel;

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
			set { isLoggedIn = value;
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

		public MainWindowViewModel()
		{
			IsLoggedIn = false;
			IsNotLoggedIn = true;
			LoginViewModel = new LoginViewModel();
			LoginViewModel.LoggedIn += OnLoggedIn;
		}

		public void OnLoggedIn(bool isLoggedIn)
		{
			IsLoggedIn = isLoggedIn;
			IsNotLoggedIn = !isLoggedIn;
			QuestionViewModel = new QuestionViewModel();			
		}

	}
}
