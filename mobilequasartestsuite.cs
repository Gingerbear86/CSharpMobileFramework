using QuasarAutomation.MobileUtils;
using QuasarAutomation.MobileHomePage;
using QuasarAutomation.MobileDocsPage;
using QuasarAutomation.MobileTablesPage;
using NUnit.Framework;

namespace QuasarAutomation.MobileQuasarTestSuite
{
    [TestFixture]
    public class YourMobileTests
    {
        private TestContext testContext;

        [SetUp]
        public void Setup()
        {
            testContext = TestContext.CurrentContext;
            MyMobileUtils.SetupDriver();
        }

        [TearDown]
        public void TearDown()
        {
            var testName = testContext?.Test.FullName;
            var testOutcome = testContext?.Result.Outcome.Status;

            MyMobileUtils.logger.Info($"Test {testName} - Outcome: {testOutcome}");

            MyMobileUtils.QuitDriver();
        }

        [Test, Order(1)]
        public void TestHomePage()
        {
            try
            {
                // Click More button on Homepage and navigate to Docs page
                var homePage = new HomePage(MyMobileUtils.Driver);
                homePage.ClickMoreButtonHome();
                homePage.ClickDocsLinkHome();
            }
            catch (Exception ex)
            {
                
                MyMobileUtils.LogError(ex, "Error occurred while running the test");
                throw;
            }
        }

        [Test, Order(2)]
        public void TestDocsPage()
        {
            try
            {
                
                var docsPage = new DocsPage(MyMobileUtils.Driver);
                docsPage.ClickMoreButton();
                docsPage.ClickDocsLink();
                docsPage.ClickHamburger();
                docsPage.ClickVueComponents();
                docsPage.ScrollToTableAndClick(); // Use the new method to scroll and click the Table element
            }
            catch (Exception ex)
            {
                
                MyMobileUtils.LogError(ex, "Error occurred while running the test");
                throw;
            }
        }
    }
}
