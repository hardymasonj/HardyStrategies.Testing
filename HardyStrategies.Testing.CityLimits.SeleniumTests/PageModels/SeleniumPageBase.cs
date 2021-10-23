using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardyStrategies.Testing.CityLimits.SeleniumTests.PageModels
{
	public class SeleniumPageBase
	{
		protected IWebDriver Driver { get; private set; }
		public SeleniumPageBase(IWebDriver oDriver)
		{
			if(oDriver == null) { throw new ArgumentNullException(nameof(oDriver)); }
			this.Driver = oDriver;
		}
	}
}
