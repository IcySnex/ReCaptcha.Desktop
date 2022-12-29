using Microsoft.UI.Xaml;

namespace ReCaptcha.Desktop.Configuration;

/// <summary>
/// Configuration for a ReCaptcha window
/// </summary>
public class WindowConfig
{
    /// <summary>
    /// Creates a new WindowConfig
    /// </summary>
    /// <param name="title">The title of the window</param>
    /// <param name="icon">The icon of the window</param>
    /// <param name="owner">The owner of this window. (Only used for StartupLocation.CenterOwner)</param>
    /// <param name="startupLocation">The startup postion of the window</param>
    /// <param name="left">The left position of the window</param>
    /// <param name="top">The top position of the window</param>
    /// <param name="showAsDialog">Wether to block the UI thread when showing the window</param>
    public WindowConfig(
        string title,
        string icon = default!,
        Window? owner = null,
        WindowStartupLocation startupLocation = WindowStartupLocation.CenterScreen,
        int left = 0,
        int top = 0,
        bool showAsDialog = false)
    {
        Title = title;
        Icon = icon;
        Owner = owner;
        ShowAsDialog = showAsDialog;
        StartupLocation = startupLocation;
        Left = left;
        Top = top;
    }


    /// <summary>
    /// The title of the window
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// The icon of the window
    /// </summary>
    public string Icon { get; set; }

    /// <summary>
    /// The owner of this window
    /// (Only used for StartupLocation.CenterOwner)
    /// </summary>
    public Window? Owner { get; set; }

    /// <summary>
    /// The startup location of the window
    /// </summary>
    public WindowStartupLocation StartupLocation { get; set; }

    /// <summary>
    /// The left position of the window
    /// </summary>
    public int Left { get; set; }

    /// <summary>
    /// The top position of the window
    /// </summary>
    public int Top { get; set; }

    /// <summary>
    /// Wether to block the UI thread when showing the window
    /// </summary>
    public bool ShowAsDialog { get; set; }
}