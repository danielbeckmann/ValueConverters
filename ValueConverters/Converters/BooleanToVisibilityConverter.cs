using System;
using Windows.UI.Xaml.Data;

namespace ValueConverters.Converters
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Converts a boolean value to a visability state. True = Visible, False = Collapsed
        /// </summary>
        /// <param name="value">The boolean value which gets converted</param>
        /// <param name="targetType">Type: Visibility</param>
        /// <param name="parameter">Provide any parameter to invert the visibility state</param>
        /// <param name="language">The language</param>
        /// <returns>Visibility</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool)
            {
                var booleanValue = (bool)value;

                if (parameter != null)
                {
                    booleanValue = !booleanValue;
                }

                if (booleanValue)
                {
                    return Windows.UI.Xaml.Visibility.Visible;
                }
            }

            return Windows.UI.Xaml.Visibility.Collapsed;
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