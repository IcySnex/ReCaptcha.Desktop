using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using ReCaptcha.Desktop.Client.WinUI;
using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.WinUI.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace ReCaptcha.Desktop.Sample.WinUI
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            AppDomain.CurrentDomain.UnhandledException += (s, e) => Debug.WriteLine($"\n\n\n{e.ExceptionObject}\n");
        }

        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            ReCaptchaClient client = new(
                "6LcMZR0UAAAAALgPMcgHwga7gY5p8QMg1Hj-bmUv".AsReCaptchaConfig(),
                "testiii".AsWindowConfig(
                    icon: "Icon.ico",
                    owner: this,
                    showAsDialog: true,
                    startupLocation: WindowStartupLocation.CenterOwner));

            client.VerificationRecieved += (s, e) => Debug.WriteLine(e.Token);
            client.VerificationCancelled += (s, e) => Debug.WriteLine(e.OccurredAt);
            client.ReCaptchaResized += (s, e) => Debug.WriteLine("{0}x{1}", e.Width, e.Height);

            try
            {
                await client.VerifyAsync(TimeSpan.FromSeconds(10));
            } catch (TaskCanceledException ex)
            {
            } catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            myButton.Content = "Clicked";
        }

    }
}
