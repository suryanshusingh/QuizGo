using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace QuizGo.Convertors
{
    class ButtonEnablerDisabler : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ("Next" == parameter.ToString())
            {
                if ((int)value > 9)
                    return false;
            }
            if ("Prev" == parameter.ToString())
            {
                if ((int)value == 1) return false;
            }
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
