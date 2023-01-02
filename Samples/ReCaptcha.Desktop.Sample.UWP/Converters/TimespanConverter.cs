using System;
using Windows.UI.Xaml.Data;

namespace ReCaptcha.Desktop.Sample.UWP.Converters;

public class TimespanConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language) =>
        ((TimeSpan)value).ToString();

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        if (TimeSpan.TryParse((string)value, out TimeSpan result))
            return result;

        return TimeSpan.Zero;
    }
}