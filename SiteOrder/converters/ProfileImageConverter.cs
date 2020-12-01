using SiteOrder.db_context;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SiteOrder.converters
{
    class ProfileImageConverter : IValueConverter
    {
        public static String defImagePath = "/public/image/def_user.png";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return value;
            }
            var currentPhoto = ((User)value).photo;
            if (currentPhoto == null || !File.Exists(currentPhoto))
            {
                return defImagePath;
            }
            return currentPhoto;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
