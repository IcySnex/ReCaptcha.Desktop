using ReCaptcha.Desktop.UWP.UI.Themes.Interfaces;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace ReCaptcha.Desktop.WinUI.UI.Themes;

/// <summary>
/// Light theme for ReCaptcha control
/// </summary>
public class LightTheme : ITheme
{
    /// <summary>
    /// The main backhround color
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush Background { get; set; } = new SolidColorBrush(Color.FromArgb(255, 249, 249, 249));

    /// <summary>
    /// The main border color
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush Border { get; set; } = new SolidColorBrush(Color.FromArgb(255, 211, 211, 211));

    /// <summary>
    /// The main foreground color
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush Foreground { get; set; } = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
    /// <summary>
    /// The secondary foreground color
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush ForegroundSecondary { get; set; } = new SolidColorBrush(Color.FromArgb(255, 85, 85, 85));

    /// <summary>
    /// The error message color
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush Error { get; set; } = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));

    /// <summary>
    /// The checkbox background color
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush CheckBoxBackground { get; set; } = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
    /// <summary>
    /// The checkbox background color when hovered
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush CheckBoxBackgroundHover { get; set; } = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
    /// <summary>
    /// The checkbox background color when pressed
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush CheckBoxBackgroundPressed { get; set; } = new SolidColorBrush(Color.FromArgb(255, 235, 235, 235));

    /// <summary>
    /// The checkbox border color
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush CheckBoxBorder { get; set; } = new SolidColorBrush(Color.FromArgb(255, 211, 211, 211));
    /// <summary>
    /// The checkbox border color when hovered
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush CheckBoxBorderHover { get; set; } = new SolidColorBrush(Color.FromArgb(255, 178, 178, 178));
    /// <summary>
    /// The checkbox border color when pressed
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush CheckBoxBorderPressed { get; set; } = new SolidColorBrush(Color.FromArgb(255, 193, 193, 193));

    /// <summary>
    /// The checkbox loading spinner color
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush CheckBoxSpinner { get; set; } = new SolidColorBrush(Color.FromArgb(255, 78, 144, 245));
    /// <summary>
    /// The checkbox checkmark color
    /// <br/>
    /// Setter will not update after initialition. 'Init-Only' is not used because of a bug in WinUI3.
    /// </summary>
    public Brush CheckBoxCheckmark { get; set; } = new SolidColorBrush(Color.FromArgb(255, 0, 158, 66));
}