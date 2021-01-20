using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ChatBot
{
    class SexoConversor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value.ToString() ==  "Robot" )
            {
                return "Resources/robot.png";
            }
            if(Properties.Settings.Default.sexo == "Hombre")
            {
                return "Resources/hombre.png";
            }
            else
            {
                return "Resources/mujer.png";
            }
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
