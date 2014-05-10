using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace ValueConverters.Converters
{
    public class DateTimeCompactConverter : IValueConverter
    {
        /// <summary>
        /// Converts a DateTime to a compact string as used on Windows Phone for Sms.
        /// </summary>
        /// <param name="value">The DateTime value which gets converted</param>
        /// <param name="targetType">Type: string</param>
        /// <param name="parameter">Provide any parameter for a more detailed output</param>
        /// <param name="language">The Language</param>
        /// <returns>String representation of the DateTime</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is DateTime)
            {
                var dateTime = (DateTime)value;
                var timeSpan = DateTime.Now - dateTime;

                if (dateTime.Date == DateTime.Today)
                {
                    return dateTime.ToString("HH:mm");
                }
                else if (timeSpan.TotalDays < 7)
                {
                    if (parameter == null)
                    {
                        return dateTime.ToString("ddd");
                    }
                    else
                    {
                        return dateTime.ToString("ddd, HH:mm");
                    }
                }
                else if (dateTime.Year == DateTime.Now.Year)
                {
                    if (parameter == null)
                    {
                        return dateTime.ToString("dd.MM");
                    }
                    else
                    {
                        return dateTime.ToString("dd.MM, HH:mm");
                    }
                }
                else
                {
                    if (parameter == null)
                    {
                        return dateTime.ToString("dd.MM.yyyy");
                    }
                    else
                    {
                        return dateTime.ToString("dd.MM.yyyy, HH:mm");
                    }
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Not implemented!
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
