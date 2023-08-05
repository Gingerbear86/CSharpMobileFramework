using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;

namespace QuasarAutomation.MobileDocsPage
{
    public class DocsPage
    {
        private IWebDriver Driver { get; }
        private By More => MobileBy.XPath("//span[@class='block' and text()='More']");
        private By Docs => MobileBy.XPath("/html/body/div[4]/div/div/a[1]/div[2]");
        private By Hamburger => MobileBy.XPath("//*[@id='q-app']/div/header/div[2]/button");
        private By VueComponents => MobileBy.XPath("//*[@id='q-app']/div/div[2]/div[1]/aside/div/div[2]/div[5]");
        private By Table => MobileBy.XPath("/html/body/div[1]/div/div[2]/div[1]/aside/div/div[2]/div[5]/div/div[2]/a[44]/div[2]");

        public DocsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void ClickMoreButton()
        {
            var moreButton = Driver.FindElement(More);
            moreButton.Click();
        }

        public void ClickDocsLink()
        {
            var docsLink = Driver.FindElement(Docs);
            docsLink.Click();
        }

        public void ClickHamburger()
        {
            var clickHamburger = Driver.FindElement(Hamburger);
            clickHamburger.Click();
        }

        public void ClickVueComponents()
        {
            var clickVueComponents = Driver.FindElement(VueComponents);
            clickVueComponents.Click();
        }

        public void ScrollDownInSmallSteps(int numberOfSteps)
        {
            // Get the JavaScript executor from the WebDriver
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;

            // Perform the scroll action multiple times using JavaScript
            for (int i = 0; i < numberOfSteps; i++)
            {
                jsExecutor.ExecuteScript("window.scrollBy(0, window.innerHeight * 0.5);");
            }
        }

        public void ScrollToElement(By locator)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;
            IWebElement element = Driver.FindElement(locator);
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView();", element);
        }

        public void ScrollToTableAndClick()
        {
            // Scroll to the Table element
            ScrollToElement(Table);

            // Now click the Table element
            ClickTableSelection();
        }

        public void ClickTableSelection()
        {
            var clickTableSelection = Driver.FindElement(Table);
            clickTableSelection.Click();
        }
    }
}
