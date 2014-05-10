using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace ValueConverters.Converters
{
    public class DateTimeToStringConverter : IValueConverter
    {
        /// <summary>
        /// Converts a DateTime to a custom formatted string.
        /// </summary>
        /// <param name="value">The DateTime value which gets converted</param>
        /// <param name="targetType">Type: string</param>
        /// <param name="parameter">DateFormat string</param>
        /// <param name="language">The Language</param>
        /// <returns>String representation of the DateTime</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is DateTime)
            {
                var dateTime = (DateTime)value;

                string formatString = parameter as string;

                if (!string.IsNullOrEmpty(formatString))
                {
                    if (!string.IsNullOrEmpty(language))
                    {
                        return dateTime.ToString(formatString, new CultureInfo(language));
                    }
                    else
                    {
                        return dateTime.ToString(formatString);
                    }
                }
                else
                {
                    return dateTime.ToString("dd.MM.yyyy");
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
