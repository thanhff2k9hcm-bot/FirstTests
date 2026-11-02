using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstTests
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void FirstSeleniumTest()
        {
            driver.Navigate().GoToUrl("https://www.google.com");

            string title = driver.Title;
            TestContext.WriteLine("Tiêu đề trang web là: " + title);

            Assert.That(title.Contains("Google"), Is.True, "Tiêu đề trang web phải chứa từ khóa Google!");
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}