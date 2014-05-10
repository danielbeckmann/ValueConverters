using System;
using Windows.UI.Xaml.Data;

namespace ValueConverters.Converters
{
    public class StringToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Converts a string into a visability state. If it has a value then Visible, null/empty = Collapsed
        /// </summary>
        /// <param name="value">The boolean value which gets converted</param>
        /// <param name="targetType">Type: Visibility</param>
        /// <param name="parameter">Params, none required</param>
        /// <param name="language">The Language</param>
        /// <returns>True = Visible, False = Collapsed</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null)
            {
                bool visible = !string.IsNullOrWhiteSpace(value.ToString());

                if (parameter != null)
                {
                    visible = !visible;
                }

                if (visible)
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