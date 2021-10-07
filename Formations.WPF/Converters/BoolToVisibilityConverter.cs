using MvvmCross.Platform.Converters;
using System;
using System.Globalization;
using System.Windows;

namespace Formations.WPF
{
    /// <summary>
    /// A converter for <see cref="Visibility"/> and bools
    /// </summary>
    class BoolToVisibilityConverter : MvxValueConverter<bool, Visibility>
    {

        protected override Visibility Convert(bool value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case true:
                    return Visibility.Visible;

                default:
                    return Visibility.Hidden;
            }
        }

        protected override bool ConvertBack(Visibility value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case Visibility.Visible:
                    return true;

                default:
                    return false;
            }
        }
    }
}
