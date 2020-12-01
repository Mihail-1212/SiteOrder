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
    public class FIO_converter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var curUser = (User)value;

            if (curUser == null)
            {
                return curUser;
            }

            return $"{curUser.surname} {curUser.name} " + (curUser.patronymic??"");
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
