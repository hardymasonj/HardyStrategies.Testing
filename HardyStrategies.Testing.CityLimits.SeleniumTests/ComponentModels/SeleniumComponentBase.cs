using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardyStrategies.Testing.CityLimits.SeleniumTests.ComponentModels
{
	public abstract class SeleniumComponentBase
	{
		private By RootBy { get; set; }
		private IWebElement _rootElement = null;
		protected IWebElement RootElement
		{
			get
			{
				if(_rootElement == null)
				{
					_rootElement = this.Driver.FindElement(this.RootBy);
				}
				return _rootElement;
			}
		}
		protected IWebDriver Driver { get; private set; } = null;
		protected SeleniumComponentBase(IWebDriver oDriver, By oRootBy)
		{
			if(oDriver == null) { throw new ArgumentNullException(nameof(oDriver)); }
			if(oRootBy == null) { throw new ArgumentNullException(nameof(oRootBy)); }

			this.Driver = oDriver;
			this.RootBy = oRootBy;
		}
	}
}
