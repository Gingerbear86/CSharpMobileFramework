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

        [Test, Order(4)]
        public void TestHomePage()
        {
            try
            {
                // Navigate to Quasar Homepage
                var homePage = new HomePage(MyMobileUtils.Driver);
                homePage.NavigateToDocs();
            }
            catch (Exception ex)
            {
                // Log the error before failing the test
                MyMobileUtils.LogError(ex, "Error occurred while running the test");
                throw;
            }
        }
                [Test, Order(5)]
        public void TestDocsPage()
        {
            try
            {
                // Navigate to Quasar Homepage
                var docsPage = new DocsPage(MyMobileUtils.Driver);
                docsPage.ClickMoreButton();
                docsPage.ClickDocsLink();
                docsPage.ClickHamburger();
                docsPage.ClickVueComponents();
                docsPage.ScrollDownInSmallSteps(1);
            }
            catch (Exception ex)
            {
                // Log the error before failing the test
                MyMobileUtils.LogError(ex, "Error occurred while running the test");
                throw;
            }
        }
    }
}
