using QuasarAutomation.MobileConfig;
using NUnit.Framework;
using NLog;
using Newtonsoft.Json;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace QuasarAutomation.MobileUtils
{
    public static class MyMobileUtils
    {
        public static readonly ILogger logger;
        private static AndroidDriver<AppiumWebElement> driver;

        static MyMobileUtils()
        {
            LogManager.Setup().LoadConfigurationFromFile("C:\\Coding\\Automation Learning\\QuasarAutomation\\nlog.config");
            logger = LogManager.GetCurrentClassLogger();
        }

        public static AndroidDriver<AppiumWebElement> Driver
        {
            get
            {
                if (driver == null)
                {
                    throw new Exception("Driver has not been set up.");
                }
                return driver;
            }
        }

        public static void NavigateToURL(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static AndroidDriver<AppiumWebElement> SetupDriver()
        {
            // Read the test configuration from the JSON file.
            var configPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "testconfig.json");
            var json = File.ReadAllText(configPath);
            var config = JsonConvert.DeserializeObject<Dictionary<string, MyMobileConfig>>(json);
            var testConfig = config["Mobile"];

            var options = new AppiumOptions();
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("browserName", "Chrome");
            options.AddAdditionalCapability("appium:automationName", "UIAutomator2");
            options.AddAdditionalCapability("platformVersion", "14.0");
            options.AddAdditionalCapability("deviceName", "emulator-5554");

            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/"), options);

            NavigateToURL(testConfig.Url);

            return driver;
        }
       
        public static void QuitDriver()
        {
            driver?.Quit();
        }

        public static void LogError(Exception ex, string message)
        {
            logger.Error(ex, message);
        }

    }
}
