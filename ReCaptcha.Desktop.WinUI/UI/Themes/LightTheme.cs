using Microsoft.UI.Xaml.Media;
using ReCaptcha.Desktop.WinUI.UI.Themes.Interfaces;
using Windows.UI;

namespace ReCaptcha.Desktop.WPF.UI.Themes;

/// <summary>
/// Light theme for ReCaptcha control
/// </summary>
public class LightTheme : ITheme
{
    /// <summary>
    /// The main backhround color
    /// </summary>
    public Brush Background { get; init; } = new SolidColorBrush(Color.FromArgb(255, 249, 249, 249));

    /// <summary>
    /// The main border color
    /// </summary>
    public Brush Border { get; init; } = new SolidColorBrush(Color.FromArgb(255, 211, 211, 211));

    /// <summary>
    /// The main foreground color
    /// </summary>
    public Brush Foreground { get; init; } = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
    /// <summary>
    /// The secondary foreground color
    /// </summary>
    public Brush ForegroundSecondary { get; } = new SolidColorBrush(Color.FromArgb(255, 85, 85, 85));

    /// <summary>
    /// The error message color
    /// </summary>
    public Brush Error { get; init; } = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));

    /// <summary>
    /// The checkbox background color
    /// </summary>
    public Brush CheckBoxBackground { get; init; } = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
    /// <summary>
    /// The checkbox background color when hovered
    /// </summary>
    public Brush CheckBoxBackgroundHover { get; init; } = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
    /// <summary>
    /// The checkbox background color when pressed
    /// </summary>
    public Brush CheckBoxBackgroundPressed { get; init; } = new SolidColorBrush(Color.FromArgb(255, 235, 235, 235));

    /// <summary>
    /// The checkbox border color
    /// </summary>
    public Brush CheckBoxBorder { get; init; } = new SolidColorBrush(Color.FromArgb(255, 211, 211, 211));
    /// <summary>
    /// The checkbox border color when hovered
    /// </summary>
    public Brush CheckBoxBorderHover { get; init; } = new SolidColorBrush(Color.FromArgb(255, 178, 178, 178));
    /// <summary>
    /// The checkbox border color when pressed
    /// </summary>
    public Brush CheckBoxBorderPressed { get; init; } = new SolidColorBrush(Color.FromArgb(255, 193, 193, 193));

    /// <summary>
    /// The checkbox loading spinner color
    /// </summary>
    public Brush CheckBoxSpinner { get; init; } = new SolidColorBrush(Color.FromArgb(255, 78, 144, 245));
    /// <summary>
    /// The checkbox checkmark color
    /// </summary>
    public Brush CheckBoxCheckmark { get; init; } = new SolidColorBrush(Color.FromArgb(255, 0, 158, 66));
}