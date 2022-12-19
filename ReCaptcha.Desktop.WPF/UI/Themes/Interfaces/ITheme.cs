using System.Windows.Media;

namespace ReCaptcha.Desktop.WPF.UI.Themes.Interfaces;

/// <summary>
/// Theme for ReCaptcha control
/// </summary>
public interface ITheme
{
    /// <summary>
    /// The main backhround color
    /// </summary>
    public SolidColorBrush Background { get; }

    /// <summary>
    /// The main border color
    /// </summary>
    public SolidColorBrush Border { get; }

    /// <summary>
    /// The main foreground color
    /// </summary>
    public SolidColorBrush Foreground { get; }
    /// <summary>
    /// The secondary foreground color
    /// </summary>
    public SolidColorBrush ForegroundSecondary { get; }

    /// <summary>
    /// The error message color
    /// </summary>
    public SolidColorBrush Error { get; }


    /// <summary>
    /// The checkbox background color
    /// </summary>
    public SolidColorBrush CheckBoxBackground { get; }
    /// <summary>
    /// The checkbox background color when hovered
    /// </summary>
    public SolidColorBrush CheckBoxBackgroundHover { get; }
    /// <summary>
    /// The checkbox background color when pressed
    /// </summary>
    public SolidColorBrush CheckBoxBackgroundPressed { get; }

    /// <summary>
    /// The checkbox border color
    /// </summary>
    public SolidColorBrush CheckBoxBorder { get; }
    /// <summary>
    /// The checkbox border color when hovered
    /// </summary>
    public SolidColorBrush CheckBoxBorderHover { get; }
    /// <summary>
    /// The checkbox border color when pressed
    /// </summary>
    public SolidColorBrush CheckBoxBorderPressed { get; }

    /// <summary>
    /// The checkbox loading spinner color
    /// </summary>
    public SolidColorBrush CheckBoxSpinner { get; }
    /// <summary>
    /// The checkbox checkmark color
    /// </summary>
    public SolidColorBrush CheckBoxCheckmark { get; }


    /// <summary>
    /// Creates a new light theme
    /// </summary>
    /// <returns>A new light theme</returns>
    public static ITheme Light() =>
        new LightTheme();

    /// <summary>
    /// Creates a new dark theme
    /// </summary>
    /// <returns>A new dark theme</returns>
    public static ITheme Dark() =>
        new DarkTheme();
}