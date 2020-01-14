using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace QuizGo.ViewModels
{
    class QuestionViewModel
    {
        Dispatcher timer;
        TimeSpan time;

        public QuestionViewModel()
        {
            timer = new Dispatcher();
            //time = TimeSpan.FromSeconds()
        }
    }
}
