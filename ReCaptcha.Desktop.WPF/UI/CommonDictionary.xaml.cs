using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;

namespace ReCaptcha.Desktop.WPF.UI;

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


    private void OnHyperlinkRequest(object _,
        RequestNavigateEventArgs e) =>
        Process.Start(new ProcessStartInfo()
        {
            FileName = e.Uri.AbsoluteUri,
            UseShellExecute = true,
            CreateNoWindow = true
        });

}