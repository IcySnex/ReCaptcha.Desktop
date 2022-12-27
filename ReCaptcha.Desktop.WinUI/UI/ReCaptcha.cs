using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Media;
using System;
using System.Windows.Input;
using ReCaptcha.Desktop.WinUI.UI.Themes.Interfaces;

namespace ReCaptcha.Desktop.WinUI.UI;

/// <summary>
/// ReCaptcha control that mimics the original Google reCAPTCHA widget
/// </summary>
public sealed class ReCaptcha : ContentControl
{
    /// <summary>
    /// Creates a new ReCaptcha control
    /// </summary>
    public ReCaptcha() =>
        DefaultStyleKey = typeof(ReCaptcha);


    /// <summary>
    /// Fires when the user requests a verification
    /// </summary>
    public event EventHandler? VerificationRequested;

    /// <summary>
    /// Fires when the user removes a verification or stops a verification request
    /// </summary>
    public event EventHandler? VerificationRemoved;


    private static void OnIsCheckedChanged(
        DependencyObject sender,
        DependencyPropertyChangedEventArgs e)
    {
        if (e.NewValue == e.OldValue)
            return;

        ReCaptcha owner = (ReCaptcha)sender;
        bool newVal = (bool)e.NewValue;

        UpdateCheckbox(owner, (bool)e.NewValue ? "True" : "False");

        (newVal ? owner.VerificationRequested : owner.VerificationRemoved)?.Invoke(owner, new());
        (newVal ? owner.VerificationRequestedCommand : owner.VerificationRemovedCommand)?.Execute(newVal == true ? owner.VerificationRequestedCommandParameter : owner.VerificationRemovedCommandParameter);
    }

    private static void OnIsLoadingChanged(
        DependencyObject sender,
        DependencyPropertyChangedEventArgs e)
    {
        if (e.NewValue == e.OldValue)
            return;

        ReCaptcha owner = (ReCaptcha)sender;
        UpdateCheckbox(owner, (bool)e.NewValue ? "Null" : owner.IsChecked ? "True" : "False");

    }

    private static void OnErrorMessageChanged(
        DependencyObject sender,
        DependencyPropertyChangedEventArgs e)
    {
        if (e.NewValue == e.OldValue)
            return;

        UpdateCheckbox((ReCaptcha)sender, string.IsNullOrEmpty((string?)e.NewValue) ? "ErrorHidden" : "ErrorVisible");
    }

    private static void UpdateCheckbox(
        ReCaptcha owner,
        string state)
    {
        CheckBox verifyCheckBox = (CheckBox)owner.GetTemplateChild("VerifyCheckBox");
        if (verifyCheckBox is null)
        {
            owner.ApplyTemplate();
            verifyCheckBox = (CheckBox)owner.GetTemplateChild("VerifyCheckBox");
        }

        Grid rootLayout = (Grid)VisualTreeHelper.GetChild(verifyCheckBox, 0);
        if (rootLayout is null)
        {
            verifyCheckBox.ApplyTemplate();
            rootLayout = (Grid)VisualTreeHelper.GetChild(verifyCheckBox, 0);
        }

        ((Storyboard)rootLayout.Resources[$"{state}Storyboard"]).Begin();
    }


    /// <summary>
    /// The command that gets executed when the user requests a verification
    /// </summary>
    public ICommand VerificationRequestedCommand
    {
        get => (ICommand)GetValue(VerificationRequestedCommandProperty);
        set => SetValue(VerificationRequestedCommandProperty, value);
    }

    /// <summary>
    /// The command property that gets executed when the user requests a verification
    /// </summary>
    public static readonly DependencyProperty VerificationRequestedCommandProperty = DependencyProperty.Register(
        "VerificationRequestedCommand", typeof(ICommand), typeof(ReCaptcha), new PropertyMetadata(null));

    /// <summary>
    /// The command that gets executed when the user requests a verification
    /// </summary>
    public object? VerificationRequestedCommandParameter
    {
        get => GetValue(VerificationRequestedCommandParameterProperty);
        set => SetValue(VerificationRequestedCommandParameterProperty, value);
    }

    /// <summary>
    /// The command property that gets executed when the user requests a verification
    /// </summary>
    public static readonly DependencyProperty VerificationRequestedCommandParameterProperty = DependencyProperty.Register(
        "VerificationRequestedCommandParameter", typeof(object), typeof(ReCaptcha), new PropertyMetadata(null));


    /// <summary>
    /// The command that gets executed when the user removes a verification or stops a verification request
    /// </summary>
    public ICommand VerificationRemovedCommand
    {
        get => (ICommand)GetValue(VerificationRemovedCommandProperty);
        set => SetValue(VerificationRemovedCommandProperty, value);
    }

    /// <summary>
    /// The command property that gets executed when the user removes a verification or stops a verification request
    /// </summary>
    public static readonly DependencyProperty VerificationRemovedCommandProperty = DependencyProperty.Register(
        "VerificationRemovedCommand", typeof(ICommand), typeof(ReCaptcha), new PropertyMetadata(null));

    /// <summary>
    /// The command that gets executed when the user removes a verification
    /// </summary>
    public object? VerificationRemovedCommandParameter
    {
        get => GetValue(VerificationRemovedCommandParameterProperty);
        set => SetValue(VerificationRemovedCommandParameterProperty, value);
    }

    /// <summary>
    /// The command property that gets executed when the user removes a verification
    /// </summary>
    public static readonly DependencyProperty VerificationRemovedCommandParameterProperty = DependencyProperty.Register(
        "VerificationRemovedCommandParameter", typeof(object), typeof(ReCaptcha), new PropertyMetadata(null));


    /// <summary>
    /// The theme used by the ReCaptcha control
    /// </summary>
    public ITheme Theme
    {
        get => (ITheme)GetValue(ThemeProperty);
        set => SetValue(ThemeProperty, value);
    }

    /// <summary>
    /// The theme property used by the ReCaptcha control
    /// </summary>
    public static readonly DependencyProperty ThemeProperty = DependencyProperty.Register(
        "Theme", typeof(ITheme), typeof(ReCaptcha), new PropertyMetadata(ITheme.Light()));


    /// <summary>
    /// The icon source shown on the right side of the ReCaptcha control
    /// </summary>
    public ImageSource Icon
    {
        get => (ImageSource)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    /// <summary>
    /// The icon source property shown on the right side of the ReCaptcha control
    /// </summary>
    public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
        "Icon", typeof(ImageSource), typeof(ReCaptcha), new PropertyMetadata(new BitmapImage(new("ms-appx:///ReCaptcha.Desktop.WinUI/UI/Assets/Icon.png"))));

    /// <summary>
    /// The title shown on the right side of the ReCaptcha control
    /// </summary>
    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    /// <summary>
    /// The title property shown on the right side of the ReCaptcha control
    /// </summary>
    public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
        "Title", typeof(string), typeof(ReCaptcha), new PropertyMetadata("reCAPTCHA"));


    /// <summary>
    /// The uri thats gets opened in the default browser when clicked on the first hyperlink
    /// </summary>
    public Uri FirstUri
    {
        get => (Uri)GetValue(FirstUriProperty);
        set => SetValue(FirstUriProperty, value);
    }

    /// <summary>
    /// The uri property thats gets opened in the default browser when clicked on the first hyperlink
    /// </summary>
    public static readonly DependencyProperty FirstUriProperty = DependencyProperty.Register(
        "FirstUri", typeof(Uri), typeof(ReCaptcha), new PropertyMetadata(new Uri("https://policies.google.com/privacy")));

    /// <summary>
    /// The text of the first hyperlink
    /// </summary>
    public string FirstUriText
    {
        get => (string)GetValue(FirstUriTextProperty);
        set => SetValue(FirstUriTextProperty, value);
    }

    /// <summary>
    /// The text property of the first hyperlink
    /// </summary>
    public static readonly DependencyProperty FirstUriTextProperty = DependencyProperty.Register(
        "FirstUriText", typeof(string), typeof(ReCaptcha), new PropertyMetadata("Privacy"));


    /// <summary>
    /// The uri thats gets opened in the default browser when clicked on the second hyperlink
    /// </summary>
    public Uri SecondaryUri
    {
        get => (Uri)GetValue(SecondaryUriProperty);
        set => SetValue(SecondaryUriProperty, value);
    }

    /// <summary>
    /// The uri property thats gets opened in the default browser when clicked on the second hyperlink
    /// </summary>
    public static readonly DependencyProperty SecondaryUriProperty = DependencyProperty.Register(
        "SecondaryUri", typeof(Uri), typeof(ReCaptcha), new PropertyMetadata(new Uri("https://policies.google.com/terms")));

    /// <summary>
    /// The text of the secondary hyperlink
    /// </summary>
    public string SecondaryUriText
    {
        get => (string)GetValue(SecondaryUriTextProperty);
        set => SetValue(SecondaryUriTextProperty, value);
    }

    /// <summary>
    /// The text property of the secondary hyperlink
    /// </summary>
    public static readonly DependencyProperty SecondaryUriTextProperty = DependencyProperty.Register(
        "SecondaryUriText", typeof(string), typeof(ReCaptcha), new PropertyMetadata("Terms"));


    /// <summary>
    /// Wether the ReCaptcha control is checked, unchecked or loading
    /// </summary>
    public bool IsChecked
    {
        get => (bool)GetValue(IsCheckedProperty);
        set => SetValue(IsCheckedProperty, value);
    }

    /// <summary>
    /// Wether the ReCaptcha control is checked, unchecked or loading property
    /// </summary>
    public static readonly DependencyProperty IsCheckedProperty = DependencyProperty.Register(
        "IsChecked", typeof(bool), typeof(ReCaptcha), new PropertyMetadata(false, OnIsCheckedChanged));


    /// <summary>
    /// Wether the ReCaptcha control shows loading
    /// </summary>
    public bool IsLoading
    {
        get => (bool)GetValue(IsLoadingProperty);
        set => SetValue(IsLoadingProperty, value);
    }

    /// <summary>
    /// Wether the ReCaptcha control shows loading property
    /// </summary>
    public static readonly DependencyProperty IsLoadingProperty = DependencyProperty.Register(
        "IsLoading", typeof(bool), typeof(ReCaptcha), new PropertyMetadata(false, OnIsLoadingChanged));


    /// <summary>
    /// The error message which gets displayed if not null
    /// </summary>
    public string? ErrorMessage
    {
        get => (string?)GetValue(ErrorMessageProperty);
        set => SetValue(ErrorMessageProperty, value);
    }

    /// <summary>
    /// The error message property which gets displayed if not null
    /// </summary>
    public static readonly DependencyProperty ErrorMessageProperty = DependencyProperty.Register(
        "ErrorMessage", typeof(string), typeof(ReCaptcha), new PropertyMetadata(null, OnErrorMessageChanged));
}