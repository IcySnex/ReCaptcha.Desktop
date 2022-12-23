using ReCaptcha.Desktop.WPF.UI.Themes.Interfaces;
using System.Windows.Media;

namespace ReCaptcha.Desktop.WPF.UI.Themes;

/// <summary>
/// Dark theme for ReCaptcha control
/// </summary>
public class DarkTheme : ITheme
{
    /// <summary>
    /// The main backhround color
    /// </summary>
    public Brush Background { get; init; } = new SolidColorBrush(Color.FromRgb(34, 34, 34));

    /// <summary>
    /// The main border color
    /// </summary>
    public Brush Border { get; init; } = new SolidColorBrush(Color.FromRgb(72, 72, 72));

    /// <summary>
    /// The main foreground color
    /// </summary>
    public Brush Foreground { get; init; } = new SolidColorBrush(Color.FromRgb(255, 255, 255));
    /// <summary>
    /// The secondary foreground color
    /// </summary>
    public Brush ForegroundSecondary { get; } = new SolidColorBrush(Color.FromRgb(170, 170, 170));

    /// <summary>
    /// The error message color
    /// </summary>
    public Brush Error { get; init; } = new SolidColorBrush(Color.FromRgb(255, 0, 0));

    /// <summary>
    /// The checkbox background color
    /// </summary>
    public Brush CheckBoxBackground { get; init; } = new SolidColorBrush(Color.FromRgb(40, 40, 40));
    /// <summary>
    /// The checkbox background color when hovered
    /// </summary>
    public Brush CheckBoxBackgroundHover { get; init; } = new SolidColorBrush(Color.FromRgb(40, 40, 40));
    /// <summary>
    /// The checkbox background color when pressed
    /// </summary>  
    public Brush CheckBoxBackgroundPressed { get; init; } = new SolidColorBrush(Color.FromRgb(60, 60, 60));

    /// <summary>
    /// The checkbox border color
    /// </summary>
    public Brush CheckBoxBorder { get; init; } = new SolidColorBrush(Color.FromRgb(84, 84, 84));
    /// <summary>
    /// The checkbox border color when hovered
    /// </summary>
    public Brush CheckBoxBorderHover { get; init; } = new SolidColorBrush(Color.FromRgb(100, 100, 100));
    /// <summary>
    /// The checkbox border color when pressed
    /// </summary>
    public Brush CheckBoxBorderPressed { get; init; } = new SolidColorBrush(Color.FromRgb(115, 115, 115));

    /// <summary>
    /// The checkbox loading spinner color
    /// </summary>
    public Brush CheckBoxSpinner { get; init; } = new SolidColorBrush(Color.FromRgb(78, 144, 245));
    /// <summary>
    /// The checkbox checkmark color
    /// </summary>
    public Brush CheckBoxCheckmark { get; init; } = new SolidColorBrush(Color.FromRgb(0, 158, 66));
}