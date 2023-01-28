using Windows.UI.Xaml;

namespace ReCaptcha.Desktop.UWP.UI;

/// <summary>
/// Default resource dictionary for using the ReCaptcha control that mimics the original Google reCAPTCHA widget
/// </summary>
public partial class CommonDictionary : ResourceDictionary
{
    /// <summary>
    /// Creates a new CommonDictionary
    /// </summary>
    public CommonDictionary() =>
        InitializeComponent();
}