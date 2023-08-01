using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
namespace QuasarAutomation.MobileHomePage
{
    public class HomePage
    {
        private IWebDriver Driver { get; }
        private By DocsLink => MobileBy.XPath("//span[@class='block' and text()='Docs']");
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateToDocs()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var docsLink = wait.Until(ExpectedConditions.ElementToBeClickable(DocsLink));
            docsLink.Click();
        }

    }
}
