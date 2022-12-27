using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using Windows.System;

namespace ReCaptcha.Desktop.WinUI.UI;

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