namespace ReCaptcha.Desktop.Configuration;

/// <summary>
/// Configuration for a ReCaptcha form
/// </summary>
public class FormConfig
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
    public FormConfig(
        string title,
        Icon icon = default!,
        Form? parent = null,
        FormStartPosition startPosition = FormStartPosition.CenterScreen,
        int left = 0,
        int top = 0,
        bool showAsDialog = false)
    {
        Title = title;
        Parent = parent;
        Icon = icon;
        ShowAsDialog = showAsDialog;
        StartPosition = startPosition;
        Left = left;
        Top = top;
    }


    /// <summary>
    /// The title of the form
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// The icon of the form
    /// </summary>
    public Icon Icon { get; set; }

    /// <summary>
    /// The parent of this form
    /// (Only used for StartupLocation.CenterParent)
    /// </summary>
    public Form? Parent { get; set; }

    /// <summary>
    /// The start position of the form
    /// </summary>
    public FormStartPosition StartPosition { get; set; }

    /// <summary>
    /// The left position of the form
    /// </summary>
    public int Left { get; set; }

    /// <summary>
    /// The top position of the form
    /// </summary>
    public int Top { get; set; }

    /// <summary>
    /// Wether to block the UI thread when showing the form
    /// </summary>
    public bool ShowAsDialog { get; set; }
}