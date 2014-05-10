using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace ValueConverters.Converters
{
    public class ObjectToStringFormatConverter : IValueConverter
    {
        /// <summary>
        /// Converts any object to a custom formatted string.
        /// </summary>
        /// <param name="value">The object which gets converted</param>
        /// <param name="targetType">Type: string</param>
        /// <param name="parameter">Format string</param>
        /// <param name="language">The Language</param>
        /// <returns>A formatted string</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string formatString = parameter as string;

            if (!string.IsNullOrEmpty(formatString))
            {
                if (!string.IsNullOrEmpty(language))
                {
                    return string.Format(new CultureInfo(language), formatString, value);
                }
                else
                {
                    return string.Format(formatString, value);
                }
            }

            return value.ToString();
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
