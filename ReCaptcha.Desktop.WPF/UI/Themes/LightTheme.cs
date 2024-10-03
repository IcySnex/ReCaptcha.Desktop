using ReCaptcha.Desktop.WPF.UI.Themes.Interfaces;
using System.Windows.Media;

namespace ReCaptcha.Desktop.WPF.UI.Themes;

/// <summary>
/// Light theme for ReCaptcha control
/// </summary>
public class LightTheme : ITheme
{
    /// <summary>
    /// The main backhround color
    /// </summary>
    public Brush Background { get; set; } = new SolidColorBrush(Color.FromRgb(249, 249, 249));

    /// <summary>
    /// The main border color
    /// </summary>
    public Brush Border { get; set; } = new SolidColorBrush(Color.FromRgb(211, 211, 211));

    /// <summary>
    /// The main foreground color
    /// </summary>
    public Brush Foreground { get; set; } = new SolidColorBrush(Color.FromRgb(0, 0, 0));
    /// <summary>
    /// The secondary foreground color
    /// </summary>
    public Brush ForegroundSecondary { get; set; } = new SolidColorBrush(Color.FromRgb(85, 85, 85));

    /// <summary>
    /// The error message color
    /// </summary>
    public Brush Error { get; set; } = new SolidColorBrush(Color.FromRgb(255, 0, 0));

    /// <summary>
    /// The checkbox background color
    /// </summary>
    public Brush CheckBoxBackground { get; set; } = new SolidColorBrush(Color.FromRgb(255, 255, 255));
    /// <summary>
    /// The checkbox background color when hovered
    /// </summary>
    public Brush CheckBoxBackgroundHover { get; set; } = new SolidColorBrush(Color.FromRgb(255, 255, 255));
    /// <summary>
    /// The checkbox background color when pressed
    /// </summary>
    public Brush CheckBoxBackgroundPressed { get; set; } = new SolidColorBrush(Color.FromRgb(235, 235, 235));

    /// <summary>
    /// The checkbox border color
    /// </summary>
    public Brush CheckBoxBorder { get; set; } = new SolidColorBrush(Color.FromRgb(211, 211, 211));
    /// <summary>
    /// The checkbox border color when hovered
    /// </summary>
    public Brush CheckBoxBorderHover { get; set; } = new SolidColorBrush(Color.FromRgb(178, 178, 178));
    /// <summary>
    /// The checkbox border color when pressed
    /// </summary>
    public Brush CheckBoxBorderPressed { get; set; } = new SolidColorBrush(Color.FromRgb(193, 193, 193));

    /// <summary>
    /// The checkbox loading spinner color
    /// </summary>
    public Brush CheckBoxSpinner { get; set; } = new SolidColorBrush(Color.FromRgb(78, 144, 245));
    /// <summary>
    /// The checkbox checkmark color
    /// </summary>
    public Brush CheckBoxCheckmark { get; set; } = new SolidColorBrush(Color.FromRgb(0, 158, 66));
}