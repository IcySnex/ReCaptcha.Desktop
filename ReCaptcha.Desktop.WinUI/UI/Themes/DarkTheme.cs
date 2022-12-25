using Microsoft.UI.Xaml.Media;
using ReCaptcha.Desktop.WinUI.UI.Themes.Interfaces;
using Windows.UI;

namespace ReCaptcha.Desktop.WPF.UI.Themes;

/// <summary>
/// Dark theme for ReCaptcha control
/// </summary>
public class DarkTheme : ITheme
{
    /// <summary>
    /// The main backhround color
    /// </summary>
    public Brush Background { get; init; } = new SolidColorBrush(Color.FromArgb(255, 34, 34, 34));

    /// <summary>
    /// The main border color
    /// </summary>
    public Brush Border { get; init; } = new SolidColorBrush(Color.FromArgb(255, 72, 72, 72));

    /// <summary>
    /// The main foreground color
    /// </summary>
    public Brush Foreground { get; init; } = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
    /// <summary>
    /// The secondary foreground color
    /// </summary>
    public Brush ForegroundSecondary { get; } = new SolidColorBrush(Color.FromArgb(255, 170, 170, 170));

    /// <summary>
    /// The error message color
    /// </summary>
    public Brush Error { get; init; } = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));

    /// <summary>
    /// The checkbox background color
    /// </summary>
    public Brush CheckBoxBackground { get; init; } = new SolidColorBrush(Color.FromArgb(255, 40, 40, 40));
    /// <summary>
    /// The checkbox background color when hovered
    /// </summary>
    public Brush CheckBoxBackgroundHover { get; init; } = new SolidColorBrush(Color.FromArgb(255, 40, 40, 40));
    /// <summary>
    /// The checkbox background color when pressed
    /// </summary>  
    public Brush CheckBoxBackgroundPressed { get; init; } = new SolidColorBrush(Color.FromArgb(255, 60, 60, 60));

    /// <summary>
    /// The checkbox border color
    /// </summary>
    public Brush CheckBoxBorder { get; init; } = new SolidColorBrush(Color.FromArgb(255, 84, 84, 84));
    /// <summary>
    /// The checkbox border color when hovered
    /// </summary>
    public Brush CheckBoxBorderHover { get; init; } = new SolidColorBrush(Color.FromArgb(255, 100, 100, 100));
    /// <summary>
    /// The checkbox border color when pressed
    /// </summary>
    public Brush CheckBoxBorderPressed { get; init; } = new SolidColorBrush(Color.FromArgb(255, 115, 115, 115));

    /// <summary>
    /// The checkbox loading spinner color
    /// </summary>
    public Brush CheckBoxSpinner { get; init; } = new SolidColorBrush(Color.FromArgb(255, 78, 144, 245));
    /// <summary>
    /// The checkbox checkmark color
    /// </summary>
    public Brush CheckBoxCheckmark { get; init; } = new SolidColorBrush(Color.FromArgb(255, 0, 158, 66));
}