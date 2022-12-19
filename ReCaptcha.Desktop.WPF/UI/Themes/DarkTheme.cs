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
    public SolidColorBrush Background { get; } = new(Color.FromRgb(34, 34, 34));

    /// <summary>
    /// The main border color
    /// </summary>
    public SolidColorBrush Border { get; } = new(Color.FromRgb(72, 72, 72));

    /// <summary>
    /// The main foreground color
    /// </summary>
    public SolidColorBrush Foreground { get; } = new(Color.FromRgb(255, 255, 255));
    /// <summary>
    /// The secondary foreground color
    /// </summary>
    public SolidColorBrush ForegroundSecondary { get; } = new(Color.FromRgb(170, 170, 170));

    /// <summary>
    /// The error message color
    /// </summary>
    public SolidColorBrush Error { get; } = new(Color.FromRgb(255, 0, 0));

    /// <summary>
    /// The checkbox background color
    /// </summary>
    public SolidColorBrush CheckBoxBackground { get; } = new(Color.FromRgb(40, 40, 40));
    /// <summary>
    /// The checkbox background color when hovered
    /// </summary>
    public SolidColorBrush CheckBoxBackgroundHover { get; } = new(Color.FromRgb(40, 40, 40));
    /// <summary>
    /// The checkbox background color when pressed
    /// </summary>
    public SolidColorBrush CheckBoxBackgroundPressed { get; } = new(Color.FromRgb(60, 60, 60));

    /// <summary>
    /// The checkbox border color
    /// </summary>
    public SolidColorBrush CheckBoxBorder { get; } = new(Color.FromRgb(84, 84, 84));
    /// <summary>
    /// The checkbox border color when hovered
    /// </summary>
    public SolidColorBrush CheckBoxBorderHover { get; } = new(Color.FromRgb(100, 100, 100));
    /// <summary>
    /// The checkbox border color when pressed
    /// </summary>
    public SolidColorBrush CheckBoxBorderPressed { get; } = new(Color.FromRgb(115, 115, 115));

    /// <summary>
    /// The checkbox loading spinner color
    /// </summary>
    public SolidColorBrush CheckBoxSpinner { get; } = new(Color.FromRgb(78, 144, 245));
    /// <summary>
    /// The checkbox checkmark color
    /// </summary>
    public SolidColorBrush CheckBoxCheckmark { get; } = new(Color.FromRgb(0, 158, 66));
}