namespace ReCaptcha.Desktop.Configuration;

public static class Extentions
{
    /// <summary>
    /// Creates a new FormConfig
    /// </summary>
    /// <param name="title">The title of the form</param>
    /// <param name="icon">The icon of the form</param>
    /// <param name="parent">The parent of this form. (Only used for StartupLocation.CenterParent)</param>
    /// <param name="startPosition">The start position of the form</param>
    /// <param name="left">The left position of the form</param>
    /// <param name="top">The top position of the form</param>
    /// <param name="showAsDialog">Wether to block the UI thread when showing the form</param>
    /// <returns>A new FormConfig</returns>
    public static FormConfig AsFormConfig(
        this string title,
        Icon icon = default!,
        Form? parent = null,
        bool showAsDialog = false,
        FormStartPosition startPosition = FormStartPosition.CenterScreen,
        int left = 0,
        int top = 0) =>
        new(title, icon, parent, startPosition, left, top, showAsDialog);
}