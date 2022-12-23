using Microsoft.Extensions.Logging;
using Microsoft.UI.Composition.SystemBackdrops;
using Microsoft.UI.Composition;
using Microsoft.UI.Xaml;
using ReCaptcha.Desktop.Sample.WinUI.Views;

namespace ReCaptcha.Desktop.Sample.WinUI.Services;

public class MicaBackdropHandler
{
    readonly ILogger logger;
    readonly ICompositionSupportsSystemBackdrop shell;

    readonly MicaController controller = new();

    /// <summary>
    /// Handler to confgure an mica backdrop effect on the current main window (Win11+)
    /// </summary>
    public MicaBackdropHandler(
        ILogger<MicaBackdropHandler> logger,
        MainView shell)
    {
        this.logger = logger;
        this.shell = (ICompositionSupportsSystemBackdrop)(Window)shell;

        controller.SetSystemBackdropConfiguration(new());

        logger.LogInformation("Registered backdrop handler and set configuration");
    }


    /// <summary>
    /// Enables the backdrop
    /// </summary>
    /// <returns>A boolean wether the backdrop effect was enabled successfully</returns>
    public bool EnableBackdrop()
    {
        if (!MicaController.IsSupported())
        {
            logger.LogError(new Exception("Unsupported"), "Failed to set system backdrop");
            return false;
        }

        try
        {
            if (shell.SystemBackdrop is not null)
            {
                logger.LogError(new Exception("SystemBackdrop is not null"), "Failed to set system backdrop");
                return false;
            }

            controller.AddSystemBackdropTarget(shell);

            logger.LogInformation("Set system backdrop");
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to set system backdrop");
            return false;
        }
    }

    /// <summary>
    /// Disables the backdrop
    /// </summary>
    /// <returns>A boolean wether the backdrop effect was disabled successfully</returns>
    public bool DisableBackdrop()
    {
        try
        {
            controller.ResetProperties();
            controller.RemoveSystemBackdropTarget(shell);

            logger.LogInformation("Disabled system backdrop and reset controller");
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to disable system backdrop and reset controller");
            return false;
        }
    }
}