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
        private By ScrollBar => MobileBy.XPath("/html/body/div[1]/div/div[2]/div[1]/aside/div");
        private By Table => MobileBy.XPath("//a[@href='/vue-components/table' and contains(@class, 'doc-layout__item')]");

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
            var clickvueComponents = Driver.FindElement(VueComponents);
            clickvueComponents.Click();
        }
        public void ScrollDownInSmallSteps(int numberOfSteps)
        {
            var touchAction = new TouchAction((AndroidDriver<AppiumWebElement>)Driver);

            // Get the size of the screen.
            var size = Driver.Manage().Window.Size;

            // Find the start and end points for the scroll.
            int startX = 330;
            int endY = (int)(size.Height * 0.9);
            int startY = (int)(size.Height * 0.4);

            // Perform the scroll action multiple times.
            for (int i = 0; i < numberOfSteps; i++)
            {
                touchAction.Press(startX, startY)
                    .Wait(500)  // optional wait
                    .MoveTo(startX, endY)
                    .Release()
                    .Perform();
            }
        }

    }
}
