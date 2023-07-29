#nullable enable

using Windows.UI.Xaml.Media;

namespace ReCaptcha.Desktop.UWP.Configuration;

/// <summary>
/// Configuration for a ReCaptcha popup
/// </summary>
public class PopupConfig
{
    /// <summary>
    /// Creates a new PopupConfig
    /// </summary>
    /// <param name="title">The title of the dialog. (Only used when HasTitleBar is true)</param>
    /// <param name="icon">The The icon of the dialog. (Only used when HasTitleBar is true)</param>
    /// <param name="hasTitleBar">Wether the dialog has a TitleBar</param>
    /// <param name="isDraggable">Wether the dialog is draggable within the main window. (Only used when HasTitleBar is true)</param>
    /// <param name="isDimmed">Wether the dialog dims the main windows background</param>
    /// <param name="hasRoundedCorners">Wether the window has rounded corners. (If null the value is true on Windows 11 and false on Windows 10)</param>
    /// <param name="startupLocation">The startup location of the popup</param>
    /// <param name="left">The left position of the popup</param>
    /// <param name="top">The top position of the popup</param>
    public PopupConfig(
        string? title = null,
        ImageSource? icon = null,
        bool hasTitleBar = true,
        bool isDraggable = false,
        bool isDimmed = true,
        bool? hasRoundedCorners = null,
        PopupStartupLocation startupLocation = PopupStartupLocation.CenterPrimary,
        int left = 0,
        int top = 0)
    {
        Title = title;
        Icon = icon;
        HasTitleBar = hasTitleBar;
        IsDragable = isDraggable;
        IsDimmed = isDimmed;
        HasRoundedCorners = hasRoundedCorners;
        StartupLocation = startupLocation;
        Left = left;
        Top = top;
    }


    /// <summary>
    /// The title of the dialog
    /// (Only used when HasTitleBar is true)
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// The icon of the dialog
    /// (Only used when HasTitleBar is true)
    /// </summary>
    public ImageSource? Icon { get; set; }

    /// <summary>
    /// Wether the dialog has a TitleBar
    /// </summary>
    public bool HasTitleBar { get; set; }

    /// <summary>
    /// Wether the dialog is draggable within the main window
    /// (Only used when HasTitleBar is true)
    /// </summary>
    public bool IsDragable { get; set; }

    /// <summary>
    /// Wether the dialog dims the main windows background
    /// </summary>
    public bool IsDimmed { get; set; }

    /// <summary>
    /// Wether the window has rounded corners
    /// (If null the value is true on Windows 11 and false on Windows 10)
    /// </summary>
    public bool? HasRoundedCorners { get; set; }

    /// <summary>
    /// The startup location of the popup
    /// </summary>
    public PopupStartupLocation StartupLocation { get; set; }

    /// <summary>
    /// The left position of the popup
    /// </summary>
    public int Left { get; set; }

    /// <summary>
    /// The top position of the popup
    /// </summary>
    public int Top { get; set; }
}