#nullable enable

using Windows.UI.Xaml.Media;

namespace ReCaptcha.Desktop.Configuration;

public static class Extentions
{
    /// <summary>
    /// Creates a new PopupConfig
    /// </summary>
    /// <param name="title">The title of the dialog. (Only used when HasTitleBar is true)</param>
    /// <param name="icon">The The icon of the dialog. (Only used when HasTitleBar is true)</param>
    /// <param name="hasTitleBar">Wether the dialog has a TitleBar</param>
    /// <param name="isDragable">Wether the dialog is draggable within the main window. (Only used when HasTitleBar is true)</param>
    /// <param name="isDimmed">Wether the dialog dims the main windows background</param>
    /// <param name="hasRoundedCorners">Wether the window has rounded corners. (If null the value is true on Windows 11 and false on Windows 10)</param>
    /// <param name="startupLocation">The startup location of the popup</param>
    /// <param name="left">The left position of the popup</param>
    /// <param name="top">The top position of the popup</param>
    /// <returns>A new DialogCOnfig</returns>
    public static PopupConfig AsPopupConfig(
        this string title,
        ImageSource? icon = null,
        bool hasTitleBar = true,
        bool isDragable = false,
        bool isDimmed = true,
        bool? hasRoundedCorners = null,
        PopupStartupLocation startupLocation = PopupStartupLocation.CenterPrimary,
        int left = 0,
        int top = 0) =>
        new(title, icon, hasTitleBar, isDragable, isDimmed, hasRoundedCorners, startupLocation, left, top);
}