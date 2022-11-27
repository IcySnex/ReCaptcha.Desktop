using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;
using ReCaptcha.Desktop.Sample.WPF.ViewModels;
using ReCaptcha.Desktop.Sample.WPF.Views;
using System.Collections.Generic;
using System.Linq;

namespace ReCaptcha.Desktop.Sample.WPF.Services;

public partial class Navigation : ObservableObject
{
    readonly ILogger<Navigation> logger;
    readonly MainView mainView;

    public Navigation(
        ILogger<Navigation> logger,
        MainView mainView,
        HomeViewModel homeViewModel,
        SettingsViewModel settingsViewModel)
    {
        this.logger = logger;
        this.mainView = mainView;

        viewModelList.Add(homeViewModel);
        viewModelList.Add(settingsViewModel);

        CurrentViewModel = viewModelList[0];
    }


    ObservableObject currentViewModel = default!;
    public ObservableObject CurrentViewModel
    {
        get => currentViewModel;
        set
        {
            SetProperty(ref currentViewModel, value);

            mainView.UserControlContainer.Content = value;
            logger.LogInformation("Navigated to page");
        }
    }

    List<ObservableObject> viewModelList = new();

    public void Navigate<T>()
    {
        if (viewModelList.FirstOrDefault(vm => vm.GetType() == typeof(T)) is ObservableObject vm)
            CurrentViewModel = vm;
    }
}