namespace ReCaptcha.Desktop.Configuration;

public static class Extentions
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
    /// <returns>A new WindowConfig</returns>
    public static WindowConfig AsWindowConfig(
        this string title,
        Icon icon = default!,
        Form? owner = null,
        bool showAsDialog = false,
        FormStartPosition startupLocation = FormStartPosition.CenterScreen,
        int left = 0,
        int top = 0) =>
        new(title, icon, owner, startupLocation, left, top, showAsDialog);
}