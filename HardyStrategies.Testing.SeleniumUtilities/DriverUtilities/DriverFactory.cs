using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HardyStrategies.Testing.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardyStrategies.Testing.SeleniumUtilities.DriverUtilities
{
	public class DriverFactory
	{
		public IWebDriver GetWebDriver(Common.Enumeration.Browsers.BrowserType eBrowserType)
		{
			switch (eBrowserType)
			{
				case Common.Enumeration.Browsers.BrowserType.Chrome:
					return new ChromeDriver(Common.Constant.TestSetup.WebDrivers.ChromeDriverLocation);
			}
			return null;
		}
	}
}
