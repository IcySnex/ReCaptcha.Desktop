using Microsoft.UI.Xaml;
using ReCaptcha.Desktop.Client.WinUI;
using ReCaptcha.Desktop.Configuration;
using System.Diagnostics;

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
                CancellationTokenSource cance = new(TimeSpan.FromSeconds(10));
                await client.VerifyAsync(cance.Token);
            }
            catch (TaskCanceledException)
            {
            }
            catch (Exception ex)
            {
            }

            myButton.Content = "DIBNE";

        }

    }
}
