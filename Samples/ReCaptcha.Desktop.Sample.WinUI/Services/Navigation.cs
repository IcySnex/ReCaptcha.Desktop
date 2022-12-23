using Microsoft.Extensions.Logging;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Media;
using ReCaptcha.Desktop.Sample.WinUI.Views;

namespace ReCaptcha.Desktop.Sample.WinUI.Services;

public class Navigation
{
    readonly ILogger logger;
    readonly MainView mainView;

    readonly List<NavigationViewItem> items;
    bool skipEvent = false;

    /// <summary>
    /// Service for navigating in the current main window
    /// </summary>
    public Navigation(
        ILogger<Navigation> logger,
        MainView mainView)
    {
        this.logger = logger;
        this.mainView = mainView;

        items = mainView.NavigationView.MenuItems
            .Concat(mainView.NavigationView.FooterMenuItems)
            .Select(item => (NavigationViewItem)item)
            .ToList();

        mainView.NavigationView.SelectionChanged += (s, e) =>
        {
            if (!skipEvent && e.SelectedItemContainer is NavigationViewItem item)
                SetCurrentPage($"Views.{item.Content}View".AsType());
        };
        mainView.NavigationView.BackRequested += (s, e) => GoBack();
        mainView.BackButton.Click += (s, e) => GoBack();

        logger.LogInformation("Registered navigation");
    }


    /// <summary>
    /// Gets the current navigation view item
    /// </summary>
    /// <returns>The current navigation view item</returns>
    public NavigationViewItem? GetCurrentNavigationViewItem() =>
        mainView.NavigationView?.SelectedItem is NavigationViewItem current ? current : null;

    /// <summary>
    /// Gets the LayoutRoot grid of the current navigation view item
    /// </summary>
    /// <returns>The current navigation view item LayoutRoot</returns>
    public Grid? GetCurrentNavigationViewItemLayoutRoot() =>
        GetCurrentNavigationViewItem() is NavigationViewItem item ? (Grid)VisualTreeHelper.GetChild(VisualTreeHelper.GetChild(VisualTreeHelper.GetChild(item, 0), 0), 0) : null;


    /// <summary>
    /// Searches for a specific navigation view item in the current NavigationView
    /// </summary>
    /// <param name="searchFor">The string to search for</param>
    /// <param name="searchForContent">The boolean wether to search in the element content</param>
    /// <param name="comparision">The string comparison mode which should be applied when searching</param>
    /// <returns>The found navigation view item</returns>
    public NavigationViewItem? GetNavigationViewItem(
        string? searchFor,
        bool searchForContent = false,
        StringComparison comparision = StringComparison.InvariantCultureIgnoreCase)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(searchFor))
                return null;

            return items.Find(item => searchFor.Equals(searchForContent ? $"ReCaptcha.Desktop.Sample.WinUI.Views.{item.Content}View" : item.Content.ToString(), comparision));
        }
        catch { return null; }
    }


    /// <summary>
    /// Sets the current navigation item
    /// </summary>
    /// <param name="item">The navigation view item which should be set</param>
    /// <returns>A boolean wether the navigation view item has been set successfully</returns>
    public bool SetCurrentNavigationViewItem(
        NavigationViewItem item)
    {
        try
        {
            mainView.NavigationView.SelectedItem = item;

            logger.LogInformation("Set current navigation item");
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to set current navigation item");
            return false;
        }
    }

    /// <summary>
    /// Sets the current navigation view item index
    /// </summary>
    /// <param name="index">The index which should be set</param>
    /// <returns>A boolean wether the current navigation view item index has been set successfully</returns>
    public bool SetCurrentIndex(
        int index)
    {
        try
        {
            NavigationViewItem selectedItem = items.ElementAt(index);

            if ((NavigationViewItem)mainView.NavigationView.SelectedItem == selectedItem)
                return false;

            skipEvent = true;
            mainView.NavigationView.SelectedItem = selectedItem;
            skipEvent = false;

            logger.LogInformation("Set current navigation item without updating page");
            return true;
        }
        catch (Exception ex)
        {
            logger.LogInformation(ex, "Failed to set current navigation item without updating page");
            return false;
        }
    }

    /// <summary>
    /// Sets the current navigation frame page
    /// </summary>
    /// <param name="type">The page which should be navigated to</param>
    /// <param name="parameter">The parameter which should get passed to</param>
    /// <returns>A boolean wether the page has been set successfully</returns>
    public bool SetCurrentPage(
        Type? type,
        object? parameter = null)
    {
        try
        {
            bool navigate = mainView.ContentFrame.Navigate(type, parameter);
            CanGoBackChanged(mainView.ContentFrame.CanGoBack);

            logger.LogInformation("Set current navigation page");
            return navigate;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to set current navigation page");
            return false;
        }
    }


    /// <summary>
    /// Navigates to the given navigation view item 
    /// </summary>
    /// <param name="item">The navigation view item which should be set</param>
    /// <returns>A boolean wether the navigation view item has been navigated to successfully</returns>
    public bool Navigate(
        NavigationViewItem? item)
    {
        if (item is null || string.IsNullOrWhiteSpace(item.Content.ToString()))
            return false;

        if ($"Views.{item.Content}View".AsType() is not null)
            return SetCurrentNavigationViewItem(item);
        else
            return false;
    }

    /// <summary>
    /// Navigates to the given page 
    /// </summary>
    /// <param name="page">The page item which should be navigated to</param>
    /// <returns>A boolean wether the page has been navigated to successfully</returns>
    public bool Navigate(string page) =>
        Navigate(GetNavigationViewItem(page));


    /// <summary>
    /// Navigates a page back
    /// </summary>
    /// <returns>A boolean wether a page back has been navigated to successfully</returns>
    public bool GoBack()
    {
        try
        {
            if (GetNavigationViewItem(mainView.ContentFrame.BackStack.Last().SourcePageType.FullName, true) is NavigationViewItem item && GetCurrentNavigationViewItem() != item)
                SetCurrentNavigationViewItem(item);
            else if (!SetCurrentPage(mainView.ContentFrame.BackStack.Last().SourcePageType))
                return false;

            mainView.ContentFrame.BackStack.RemoveAt(mainView.ContentFrame.BackStackDepth - 1);
            mainView.ContentFrame.BackStack.RemoveAt(mainView.ContentFrame.BackStackDepth - 1);
            CanGoBackChanged(mainView.ContentFrame.CanGoBack);

            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to go back current navigation page");
            return false;
        }
    }

    /// <summary>
    /// Clears the GoBack backstack
    /// </summary>
    public void ClearBackStack()
    {
        mainView.ContentFrame.BackStack.Clear();
        CanGoBackChanged(false);
    }

    void CanGoBackChanged(
        bool canGoBack)
    {
        if (canGoBack == (mainView.BackButton.Opacity != 0))
            return;

        if (canGoBack)
        {
            mainView.BackButton.Opacity = 1;
            ((Storyboard)mainView.BackButton.Resources["InBoard"]).Begin();
        }
        else
        {
            mainView.BackButton.Opacity = 0;
            ((Storyboard)mainView.BackButton.Resources["OutBoard"]).Begin();
        }
    }
}