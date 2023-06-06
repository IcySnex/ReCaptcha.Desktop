using Microsoft.Extensions.DependencyInjection;
using SimpleExampleMVVM.ViewModel;
using System.Windows.Controls;

namespace SimpleExampleMVVM.Views;

public partial class CaptchaView : UserControl
{
    public CaptchaView()
    {
        InitializeComponent();
        DataContext = App.Provider.GetRequiredService<CaptchaViewModel>();
    }
}