namespace ReCaptcha.Desktop.Configuration;

/// <summary>
/// Specifies where a window will be located on startup
/// </summary>
public enum WindowStartupLocation
{
    /// <summary>
    /// The window location will be set manual on the primary screen at startup
    /// </summary>
    Manual,

    /// <summary>
    /// The window location will be centered on the primary screen at startup
    /// </summary>
    CenterScreen,

    /// <summary>
    /// The window location will be centered on the owner window at startup
    /// </summary>
    CenterOwner
}