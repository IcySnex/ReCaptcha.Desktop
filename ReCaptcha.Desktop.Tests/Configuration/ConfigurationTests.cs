using ReCaptcha.Desktop.Configuration;

namespace ReCaptcha.Desktop.Tests.Configuration;

class ConfigurationTests
{
	[Test]
	public void Create_NewConfigration_Success()
	{
		// Create new Configuration
		HttpServerConfig configruation = new(TestData.HostUrl, TestData.HostPort);

        // Run Test: Expected behaviour: Given url and port does equal to configuration values
		Assert.That(configruation.Url, Is.EqualTo(TestData.HostUrl));
		Assert.That(configruation.Port, Is.EqualTo(TestData.HostPort));
	}

	[Test]
	public void Create_NewConfigrationFromString_Success()
	{
		// Create new Configuration
		HttpServerConfig configruation = TestData.HostUrl.AsHttpServerConfig(TestData.HostPort);

        // Run Test: Expected behaviour: Given url and port does equal to configuration values
        Assert.That(configruation.Url, Is.EqualTo(TestData.HostUrl));
		Assert.That(configruation.Port, Is.EqualTo(TestData.HostPort));
	}
}