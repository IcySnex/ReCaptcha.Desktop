using ReCaptcha.Desktop.Configuration;
using ReCaptcha.Desktop.HTTP;
using ReCaptcha.Desktop.HTTP.Interfaces;
using System.Diagnostics;
using System.Text;

namespace ReCaptcha.Desktop.Tests.HTTP;

class HttpServerTests
{
    HttpServerConfig config;
    IHttpServer server; 

    [OneTimeSetUp]
    public void Setup()
    {
        // Mock config/server
        config = new(TestData.HostUrl, TestData.HostPort);
        server = new HttpServer(config, TestData.WebContent);
    }


    [Test]
    public async Task Start_Success()
    {
        // Mock result
        string[] prefixes = default!;

        // Run Test: Expected behaviour: Run without exception
        Assert.DoesNotThrow(() =>
        {
            // Start server
            prefixes = server.Start();
        });

        // Write result
        string result = $"Prefixes:\n{string.Join('\n', prefixes)}";
        TestContext.WriteLine(result);

        // Wait for test purposes
        if (TestData.WaitInTests)
            await Task.Delay(TestData.WaitTimespan);
    }

    [Test]
    public void Stop_Success()
    {
        // Run Test: Expected behaviour: Run without exception
        Assert.DoesNotThrowAsync(async () =>
        {
            // First start server so it can be stopped
            server.Start();

            // Wait for test purposes
            if (TestData.WaitInTests)
                await Task.Delay(TestData.WaitTimespan);

            // Stop server
            server.Stop();
        });
    }

    [Test]
    public async Task Events_Success()
    {
        // Regitser server events
        server.Started += (s, e) =>
        {
            string result =
                "\nServer started:\n" +
                $"Url: {e.Url}\n" +
                $"Port: {e.Port}\n" +
                $"Prefixes: {string.Join(", ", e.Prefixes)}\n" +
                $"Occurred at: {e.OccurredAt}\n";
            Debug.WriteLine(result);
        };
        server.Stopped += (s, e) =>
        {
            string result =
                "\nServer stopped:\n" +
                $"Url: {e.Url}\n" +
                $"Port: {e.Port}\n" +
                $"Occurred at: {e.OccurredAt}\n";
            Debug.WriteLine(result);
        };
        server.RequestOccurred += (s, e) =>
        {
            string result =
                "\nRequest occurred:\n" +
                $"User agent: {e.Context.Request.UserAgent}\n" +
                $"Response: {Encoding.ASCII.GetString(e.Response)}\n" +
                $"Occurred at: {e.OccurredAt}\n";
            Debug.WriteLine(result);
        };
        server.RequestErrorOccurred += (s, e) =>
        {
            string result =
                "\nRequest error occurred:\n" +
                $"Exception: {e.Exception.Message}\n" +
                $"Inner Exception: {e.Exception.InnerException?.Message ?? "N/A"}\n" +
                $"Occurred at: {e.OccurredAt}\n";
            Debug.WriteLine(result);
        };

        // First start server
        server.Start();

        // Wait for test purposes
        if (TestData.WaitInTests)
            await Task.Delay(TestData.WaitTimespan);

        // Stop server
        server.Stop();
    }
}