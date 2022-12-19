﻿using ReCaptcha.Desktop.WPF.UI.Themes.Interfaces;
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
    public SolidColorBrush Background { get; } = new(Color.FromRgb(249, 249, 249));

    /// <summary>
    /// The main border color
    /// </summary>
    public SolidColorBrush Border { get; } = new(Color.FromRgb(211, 211, 211));

    /// <summary>
    /// The main foreground color
    /// </summary>
    public SolidColorBrush Foreground { get; } = new(Color.FromRgb(0, 0, 0));
    /// <summary>
    /// The secondary foreground color
    /// </summary>
    public SolidColorBrush ForegroundSecondary { get; } = new(Color.FromRgb(85, 85, 85));

    /// <summary>
    /// The error message color
    /// </summary>
    public SolidColorBrush Error { get; } = new(Color.FromRgb(255, 0, 0));

    /// <summary>
    /// The checkbox background color
    /// </summary>
    public SolidColorBrush CheckBoxBackground { get; } = new(Color.FromRgb(255, 255, 255));
    /// <summary>
    /// The checkbox background color when hovered
    /// </summary>
    public SolidColorBrush CheckBoxBackgroundHover { get; } = new(Color.FromRgb(255, 255, 255));
    /// <summary>
    /// The checkbox background color when pressed
    /// </summary>
    public SolidColorBrush CheckBoxBackgroundPressed { get; } = new(Color.FromRgb(235, 235, 235));

    /// <summary>
    /// The checkbox border color
    /// </summary>
    public SolidColorBrush CheckBoxBorder { get; } = new(Color.FromRgb(211, 211, 211));
    /// <summary>
    /// The checkbox border color when hovered
    /// </summary>
    public SolidColorBrush CheckBoxBorderHover { get; } = new(Color.FromRgb(178, 178, 178));
    /// <summary>
    /// The checkbox border color when pressed
    /// </summary>
    public SolidColorBrush CheckBoxBorderPressed { get; } = new(Color.FromRgb(193, 193, 193));

    /// <summary>
    /// The checkbox loading spinner color
    /// </summary>
    public SolidColorBrush CheckBoxSpinner { get; } = new(Color.FromRgb(78, 144, 245));
    /// <summary>
    /// The checkbox checkmark color
    /// </summary>
    public SolidColorBrush CheckBoxCheckmark { get; } = new(Color.FromRgb(0, 158, 66));
}