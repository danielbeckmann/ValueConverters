using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace ValueConverters.Converters
{
    public class IntegerToAlternatingBrushConverter : IValueConverter
    {
        private SolidColorBrush brightBrush = new SolidColorBrush(Color.FromArgb(255, 100, 100, 100));
        private SolidColorBrush darkBrush = new SolidColorBrush(Color.FromArgb(255, 30, 30, 30));

        /// <summary>
        /// Converts an int value to a alternating Brush.
        /// </summary>
        /// <param name="value">The int value which gets converted</param>
        /// <param name="targetType">Type: SolidColorBrush</param>
        /// <param name="parameter">Any parameter to change alternating starting color</param>
        /// <param name="language">The Language</param>
        /// <returns>String representation of the DateTime</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is int)
            {
                int index = (int)value;

                // Change change alternating starting color
                if (parameter != null)
                {
                    index++;
                }

                if (index % 2 != 0)
                {
                    return brightBrush;
                }
            }

            return darkBrush;
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