using HardyStrategies.Testing.CityLimits.SeleniumTests.PageModels;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HardyStrategies.Testing.CityLimits
{
	public class HomeTest
	{
		private HomePage HomePage { get; set; }
		private IWebDriver Driver { get; set; }
		[SetUp]
		public void Setup()
		{
			this.Driver = new ChromeDriver(@"C:\Program Files (x86)\WebDrivers\Chrome94");
			this.HomePage = new HomePage(this.Driver);
			this.HomePage.NavigateToPage();
		}

		[Test]
		public void PrimaryPhoneTest()
		{
			var strExpected = "tel:+12189995900";
			var strActual = this.HomePage.Footer.GetPhoneNumberTarget();
			Assert.AreEqual(strExpected, strActual);
		}

		[Test]
		public void NavigateToFacebookTest()
		{
			this.HomePage.Footer.NavigateToFacebook();
			new WebDriverWait(this.Driver, new System.TimeSpan(0, 0, 30));
			this.Driver.SwitchTo().Window(this.Driver.WindowHandles[1]);
			Assert.IsTrue(this.Driver.Url.StartsWith("https://www.facebook.com/CityLimitsStorageCenter/"));
		}

		[TearDown]
		public void Teardown()
		{
			this.Driver.Quit();

			this.HomePage = null;
			this.Driver = null;
		}
	}
}