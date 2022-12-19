using ReCaptcha.Desktop.WPF.UI.Themes.Interfaces;
using System.Windows.Media;

namespace ReCaptcha.Desktop.WPF.UI.Themes;

/// <summary>
/// Custom theme for ReCaptcha control
/// Should be used with XAML. Code behind should create a new Class which inherets <see cref="ITheme"/>
/// </summary>
public class CustomTheme : ITheme
{
    /// <summary>
    /// Creates a new CustomTheme
    /// </summary>
    /// <param name="background">The main backhround color</param>
    /// <param name="border">The main border color</param>
    /// <param name="foreground">The main foreground color</param>
    /// <param name="foregroundSecondary">The secondary foreground color</param>
    /// <param name="error">The error message color</param>
    /// <param name="checkBoxBackground">The checkbox background color</param>
    /// <param name="checkBoxBackgroundHover">The checkbox background color when hovered</param>
    /// <param name="checkBoxBackgroundPressed">The checkbox background color when pressed</param>
    /// <param name="checkBoxBorder">The checkbox border color</param>
    /// <param name="checkBoxBorderHover">The checkbox border color when hovered</param>
    /// <param name="checkBoxBorderPressed">The checkbox border color when pressed</param>
    /// <param name="checkBoxSpinner">The checkbox loading spinner color</param>
    /// <param name="checkBoxCheckmark">The checkbox checkmark color</param>
    /// <param name="basedOn">The theme this theme is based on (default: <see cref="ITheme.Light"/>)</param>
    public CustomTheme(
        SolidColorBrush? background = null,
        SolidColorBrush? border = null,
        SolidColorBrush? foreground = null,
        SolidColorBrush? foregroundSecondary = null,
        SolidColorBrush? error = null,
        SolidColorBrush? checkBoxBackground = null,
        SolidColorBrush? checkBoxBackgroundHover = null,
        SolidColorBrush? checkBoxBackgroundPressed = null,
        SolidColorBrush? checkBoxBorder = null,
        SolidColorBrush? checkBoxBorderHover = null,
        SolidColorBrush? checkBoxBorderPressed = null,
        SolidColorBrush? checkBoxSpinner = null,
        SolidColorBrush? checkBoxCheckmark = null,
        ITheme? basedOn = null)
    {
        basedOn ??= ITheme.Light();

        Background = background ?? basedOn.Background;
        Border = border ?? basedOn.Border;
        Foreground = foreground ?? basedOn.Foreground;
        ForegroundSecondary = foregroundSecondary ?? basedOn.ForegroundSecondary;
        Error = error ?? basedOn.Error; 
        CheckBoxBackground = checkBoxBackground ?? basedOn.CheckBoxBackground;
        CheckBoxBackgroundHover = checkBoxBackgroundHover ?? basedOn.CheckBoxBackgroundHover;
        CheckBoxBackgroundPressed = checkBoxBackgroundPressed ?? basedOn.CheckBoxBackgroundPressed;
        CheckBoxBorder = checkBoxBorder ?? basedOn.CheckBoxBorder;
        CheckBoxBorderHover = checkBoxBorderHover ?? basedOn.CheckBoxBorderHover;
        CheckBoxBorderPressed = checkBoxBorderPressed ?? basedOn.CheckBoxBorderPressed;
        CheckBoxSpinner = checkBoxSpinner ?? basedOn.CheckBoxSpinner;
        CheckBoxCheckmark = checkBoxCheckmark ?? basedOn.CheckBoxCheckmark;
    }

    /// <summary>
    /// The main backhround color
    /// </summary>
    public SolidColorBrush Background { get; set; }

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
}