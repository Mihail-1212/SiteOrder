using SiteOrder.db_context;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SiteOrder.converters
{
    class StatusTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return value;

            String resultText = "";

            switch ((TechnicalTask_status)value) 
            {
                case TechnicalTask_status.canceled:
                    resultText = "Техническое задание не выполнено!";
                    //Техническое задание не выполнено!
                    break;
                case TechnicalTask_status.completed:
                    resultText = "Техническое задание выполнено!";
                    //Техническое задание выполнено!
                    break;
                case TechnicalTask_status.processing:
                    resultText = "Техническое задание выполняется!";
                    //Техническое задание не выполнено!
                    break;
            }


            return resultText;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
