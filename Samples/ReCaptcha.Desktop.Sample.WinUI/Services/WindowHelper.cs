using Microsoft.Extensions.Logging;
using Microsoft.UI;
using Windows.System;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using ReCaptcha.Desktop.Sample.WinUI.Views;
using System.Runtime.InteropServices;
using WinRT.Interop;

namespace ReCaptcha.Desktop.Sample.WinUI.Services;

/// <summary>
/// Helps maintaining windows
/// </summary>
public class WindowHelper
{
    readonly MainView mainView;
    readonly AppWindow window;
    readonly ILogger logger;

    /// <summary>
    /// Creates a new WindowHelper with with optional logging functions
    /// </summary>
    /// <param name="window">The winodw which is used in the helper</param>
    /// <param name="logger">The logger which will be used for logging</param>
    public WindowHelper(
        MainView mainView,
        ILogger<WindowHelper> logger)
    {
        HWnd = GetHWnd(mainView);
        window = AppWindow.GetFromWindowId(Win32Interop.GetWindowIdFromWindow(HWnd));
        this.mainView = mainView;
        this.logger = logger;
    }


    /// <summary>
    /// Gets the HWND of an owner window
    /// </summary>
    /// <param name="owner">The owner window</param>
    /// <returns></returns>
    public static IntPtr GetHWnd(
        Window owner) =>
        WindowNative.GetWindowHandle(owner);


    /// <summary>
    /// HWND of the current main window
    /// </summary>
    public readonly IntPtr HWnd;

    /// <summary>
    /// Active logger window (null if none is active)
    /// </summary>
    public LoggerView? LoggerView = null;

    /// <summary>
    /// Creates and activates a new window which hooks to the logger events
    /// </summary>
    public void CreateLoggerView()
    {
        if (LoggerView is not null)
        {
            LoggerView.Activate();
            return;
        }

        LoggerView loggerView = new() { Title = "IcyLauncher - Logger" };

        void handler(object? s, string e) =>
            loggerView.ContentBlock.Text += e;

        App.Sink.OnNewLog += handler;
        loggerView.Closed += (s, e) =>
        {
            App.Sink.OnNewLog -= handler;
            LoggerView = null;
        };

        SetSize(loggerView, 700, 400);
        LoggerView = loggerView;
        loggerView.Activate();

        logger.LogInformation("Created new LoggerWindow and hooked handler");
    }


    /// <summary>
    /// Sets a custom icon on the current main window
    /// </summary>
    /// <param name="path">The file path to the icon</param>
    public void SetIcon(
        string path)
    {
        window.SetIcon(path);

        logger.LogInformation("[WindowHelper-SetIcon] Set app icon [{path}]", path);
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

        logger.LogInformation("[WindowHelper-SetSize] Set window size [{width}x{height}]", width, height);
    }
    /// <summary>
    /// Sets the size of the given window
    /// </summary>
    /// <param name="externalWindow">The window to set the size to</param>
    /// <param name="width">The width of the new size</param>
    /// <param name="height">The height of the new size</param>
    public void SetSize(
        Window externalWindow,
        int width,
        int height)
    {
        IntPtr hWnd = WindowNative.GetWindowHandle(externalWindow);
        AppWindow window = AppWindow.GetFromWindowId(Win32Interop.GetWindowIdFromWindow(hWnd));

        window.Resize(new(width, height));

        logger.LogInformation("Set external window size [{width}x{height}]", width, height);
    }

    /// <summary>
    /// Sets an UIElement as a custom title bar on the current main window
    /// </summary>
    /// <param name="titleBar">The UIElement to set as a title bar</param>
    /// <param name="container">The container UIElement of the title bar to update visibilies</param>
    /// <returns>A boolean wether the UIElement was set as the custom title bar successfully</returns>
    public bool SetTitleBar(
        UIElement? titleBar,
        UIElement? container = null)
    {
        try
        {
            if (titleBar is null)
            {
                if (container is not null)
                    container.Visibility = Visibility.Collapsed;

                mainView.ExtendsContentIntoTitleBar = false;
                mainView.SetTitleBar(null);

                logger.LogInformation("Removed custom TitleBar");
                return true;
            }

            if (container is not null)
                container.Visibility = Visibility.Visible;

            mainView.ExtendsContentIntoTitleBar = true;
            mainView.SetTitleBar(titleBar);

            logger.LogInformation("Set custom TitleBar");
            return true;
        }
        catch (Exception ex)
        {
            logger.LogInformation("Failed to set custom TitleBar", ex);
            return false;
        }
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct DISPATCHERQUEUEOPTIONS
    {
        public int dwSize;
        public int threadType;
        public int apartmentType;
    }

    [DllImport("CoreMessaging.dll")]
    public static extern IntPtr CreateDispatcherQueueController(
        [In] DISPATCHERQUEUEOPTIONS options,
        [In, Out, MarshalAs(UnmanagedType.IUnknown)] ref object? dispatcherQueueController);

    object? dispatcherQueueController;

    /// <summary>
    /// Ensures there is a windows system dispatcher queue controller
    /// </summary>
    /// <returns>A boolean wether the action was successful</returns>
    public bool EnsureWindowsSystemDispatcherQueueController()
    {
        if (DispatcherQueue.GetForCurrentThread() is not null || dispatcherQueueController is not null)
        {
            logger.LogError(new Exception("DispatcherQueue is not null"), "Failed to ensure DispatcherQueueController");
            return false;
        }

        CreateDispatcherQueueController(new()
        {
            dwSize = Marshal.SizeOf(typeof(DISPATCHERQUEUEOPTIONS)),
            threadType = 2,
            apartmentType = 2
        }, ref dispatcherQueueController);

        logger.LogInformation("Ensured DispatcherQueueController");
        return true;
    }
}