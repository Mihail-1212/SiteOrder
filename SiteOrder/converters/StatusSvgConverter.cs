using SiteOrder.db_context;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace SiteOrder.converters
{
    public class StatusSvgConverter : IValueConverter
    {
        public static readonly String status_completed = "M20,12A8,8 0 0,1 12,20A8,8 0 0,1 4,12A8,8 0 0,1 12,4C12.76,4 13.5,4.11 14.2,4.31L15.77,2.74C14.61,2.26 13.34,2 12,2A10,10 0 0,0 2,12A10,10 0 0,0 12,22A10,10 0 0,0 22,12M7.91,10.08L6.5,11.5L11,16L21,6L19.59,4.58L11,13.17L7.91,10.08Z";

        public static readonly String status_canceled = "M20,12A8,8 0 0,1 12,20A8,8 0 0,1 4,12A8,8 0 0,1 20,12M12,2A10,10 0 0,0 2,12A10,10 0 0,0 12,22A10,10 0 0,0 22,12A10,10 0 0,0 12,2   M6,8 L8,6 L18,16 L16,18  M16,6 L18,8 L8,18 L6,16  M12,10L14,12L12,14L10,12";

        public static readonly String status_processing = "M6,2H18V8H18V8L14,12L18,16V16H18V22H6V16H6V16L10,12L6,8V8H6V2M16,16.5L12,12.5L8,16.5V20H16V16.5M12,11.5L16,7.5V4H8V7.5L12,11.5M10,6H14V6.75L12,8.75L10,6.75V6Z";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return value;

            String svgImage = "";

            switch ((TechnicalTask_status)value)
            {
                case TechnicalTask_status.completed:
                    svgImage = status_completed;
                    break;
                case TechnicalTask_status.canceled:
                    svgImage = status_canceled;
                    break;
                case TechnicalTask_status.processing:
                    svgImage = status_processing;
                    break;
            }

            return svgImage;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
