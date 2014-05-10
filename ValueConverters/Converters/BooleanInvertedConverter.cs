using System;
using Windows.UI.Xaml.Data;

namespace ValueConverters.Converters
{
    public class BooleanInvertedConverter : IValueConverter
    {
        /// <summary>
        /// Inverts a boolean value
        /// </summary>
        /// <param name="value">The boolean value which gets inverted</param>
        /// <param name="targetType">Type: Visibility</param>
        /// <param name="parameter">Params, none required</param>
        /// <param name="language">The Language</param>
        /// <returns>Visibility</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool)
            {
                var booleanValue = (bool)value;
                return !booleanValue;
            }

            return true;
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