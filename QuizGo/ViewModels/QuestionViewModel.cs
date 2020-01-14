using System;
using System.Collections.Generic;
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

        public string TimeRemaining
        {
            get { return timeRemaining; }
            set { 
                timeRemaining = value;
                OnPropertyChange("TimeRemaining");
            }
        }


        public QuestionViewModel()
        {
            StartTimer();
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
