using System;
using System.Globalization;
using System.Windows.Data;

namespace ReCaptcha.Desktop.Sample.WPF.Converters;

public class TimeSpanConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        try
        {
            return ((TimeSpan)value).ToString("hh':'mm':'ss");
        }
        catch
        {
            return TimeSpan.Zero;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        try
        {
            return TimeSpan.ParseExact((string)value, "hh':'mm':'ss", CultureInfo.CurrentCulture);
        }
        catch
        {
            return "00:00:00";
        }
    }
}