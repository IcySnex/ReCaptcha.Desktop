using Windows.UI.Xaml.Media;

namespace ReCaptcha.Desktop.UWP.UI.Themes.Interfaces;

/// <summary>
/// Theme for ReCaptcha control
/// </summary>
public interface ITheme
{
    /// <summary>
    /// The main backhround color
    /// </summary>
    public Brush Background { get; }

    /// <summary>
    /// The main border color
    /// </summary>
    public Brush Border { get; }

    /// <summary>
    /// The main foreground color
    /// </summary>
    public Brush Foreground { get; }
    /// <summary>
    /// The secondary foreground color
    /// </summary>
    public Brush ForegroundSecondary { get; }

    /// <summary>
    /// The error message color
    /// </summary>
    public Brush Error { get; }


    /// <summary>
    /// The checkbox background color
    /// </summary>
    public Brush CheckBoxBackground { get; }
    /// <summary>
    /// The checkbox background color when hovered
    /// </summary>
    public Brush CheckBoxBackgroundHover { get; }
    /// <summary>
    /// The checkbox background color when pressed
    /// </summary>
    public Brush CheckBoxBackgroundPressed { get; }

    /// <summary>
    /// The checkbox border color
    /// </summary>
    public Brush CheckBoxBorder { get; }
    /// <summary>
    /// The checkbox border color when hovered
    /// </summary>
    public Brush CheckBoxBorderHover { get; }
    /// <summary>
    /// The checkbox border color when pressed
    /// </summary>
    public Brush CheckBoxBorderPressed { get; }

    /// <summary>
    /// The checkbox loading spinner color
    /// </summary>
    public Brush CheckBoxSpinner { get; }
    /// <summary>
    /// The checkbox checkmark color
    /// </summary>
    public Brush CheckBoxCheckmark { get; }


    ///// <summary>
    ///// Creates a new light theme
    ///// </summary>
    ///// <returns>A new light theme</returns>
    //public static ITheme Light() =>
    //    new LightTheme();

    ///// <summary>
    ///// Creates a new dark theme
    ///// </summary>
    ///// <returns>A new dark theme</returns>
    //public static ITheme Dark() =>
    //    new DarkTheme();
}