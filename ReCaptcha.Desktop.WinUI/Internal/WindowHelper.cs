using Microsoft.Extensions.Logging;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using System;
using System.Runtime.InteropServices;
using Windows.Graphics;
using WinRT.Interop;

namespace ReCaptcha.Desktop.WinUI.Internal;

internal class WindowHelper
{
    readonly AppWindow window;
    readonly ILogger? logger;

    /// <summary>
    /// Creates a new WindowHelper with with optional logging functions
    /// </summary>
    /// <param name="window">The winodw which is used in the helper</param>
    /// <param name="logger">The logger which will be used for logging</param>
    public WindowHelper(
        Window window,
        ILogger? logger = null)
    {
        HWnd = GetHWnd(window);
        this.window = AppWindow.GetFromWindowId(Win32Interop.GetWindowIdFromWindow(HWnd));
        this.logger = logger;

        ((OverlappedPresenter)this.window.Presenter).IsResizable = false;
        ((OverlappedPresenter)this.window.Presenter).IsMinimizable = false;
        ((OverlappedPresenter)this.window.Presenter).IsMaximizable = false;
    }


    /// <summary>
    /// Gets the position and size of an owner window
    /// </summary>
    /// <param name="owner">The owner window</param>
    /// <returns>The position and size</returns>
    public static (PointInt32?, SizeInt32?) GetOwnerWindow(
        Window? owner)
    {
        if (owner is null)
            return (null, null);

        AppWindow ownerWindow = AppWindow.GetFromWindowId(Win32Interop.GetWindowIdFromWindow(GetHWnd(owner)));
        return (ownerWindow.Position, ownerWindow.Size);
    }

    /// <summary>
    /// Gets the HWND of an owner window
    /// </summary>
    /// <param name="owner">The owner window</param>
    /// <returns></returns>
    public static IntPtr GetHWnd(
        Window owner) =>
        WindowNative.GetWindowHandle(owner);


    public static IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong) =>
        IntPtr.Size == 8 ? SetWindowLongPtr64(hWnd, nIndex, dwNewLong) : new(SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));

    [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
    private static extern int SetWindowLong32(IntPtr hWnd, int nIndex, int dwNewLong);

    [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
    private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);


    /// <summary>
    /// HWND of the current main window
    /// </summary>
    public readonly IntPtr HWnd;

    /// <summary>
    /// Position of the current main window
    /// </summary>
    public PointInt32 Position => window.Position;

    /// <summary>
    /// Size of the current main window
    /// </summary>
    public SizeInt32 Size => window.Size;

    /// <summary>
    /// Gets or sets wether the current main window is modal
    /// </summary>
    public bool IsModal
    {
        get => ((OverlappedPresenter) window.Presenter).IsModal;
        set => ((OverlappedPresenter)window.Presenter).IsModal = value;
    }

    /// <summary>
    /// Size of the current main screen
    /// </summary>
    public RectInt32 ScreenSize => DisplayArea.GetFromWindowId(Win32Interop.GetWindowIdFromWindow(HWnd), DisplayAreaFallback.Nearest).WorkArea;


    /// <summary>
    /// Sets a custom icon on the current main window
    /// </summary>
    /// <param name="path">The file path to the icon</param>
    public void SetIcon(
        string path)
    {
        window.SetIcon(path);

        logger?.LogInformation("[WindowHelper-SetIcon] Set app icon [{path}]", path);
    }

    /// <summary>
    /// Sets the size of the current main window
    /// </summary>
    /// <param name="width">The width of the new size</param>
    /// <param name="height">The height of the new size</param>
    public void SetSize(
        int width,
        int height)
    {
        window.Resize(new(width + 16, height + 39));

        logger?.LogInformation("[WindowHelper-SetSize] Set window size [{width}x{height}]", width, height);
    }

    /// <summary>
    /// Sets the position of the current main window
    /// </summary>
    /// <param name="x">The x coordinate of the new size</param>
    /// <param name="y">The y coordinate of the new size</param>
    public void SetPosition(
        int x,
        int y)
    {
        window.Move(new(x, y));

        logger?.LogInformation("[WindowHelper-SetPosition] Set window position [{x}, {y}]", x, y);
    }
}