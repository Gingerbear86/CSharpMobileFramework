using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
namespace QuasarAutomation.MobileHomePage
{
    public class HomePage
    {
        private IWebDriver Driver { get; }
        private By More => MobileBy.XPath("//span[@class='block' and text()='More']");
        private By DocsLink => MobileBy.XPath("/html/body/div[4]/div/div/a[1]/div[2]");
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }
        public void ClickMoreButtonHome()
        {
            var moreButton = Driver.FindElement(More);
            moreButton.Click();
        }
        public void ClickDocsLinkHome()
        {
            var docsLink = Driver.FindElement(DocsLink);
            docsLink.Click();
        }

    }
}
