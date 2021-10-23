using HardyStrategies.Testing.CityLimits.Models.BasePages;
using HardyStrategies.Testing.CityLimits.Models.Components;
using HardyStrategies.Testing.CityLimits.SeleniumTests.ComponentModels;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace HardyStrategies.Testing.CityLimits.SeleniumTests.PageModels
{
	public class HomePage : SeleniumPageBase, ICityLimitsPage
	{
		public const string _url = "https://citylimitsstoragecenter.com/";
		public HomePage(IWebDriver oDriver) : base(oDriver)
		{
			this.Footer = new FooterComponent(oDriver);
		}

		public INavigationComponent Navigation { get; private set; }

		public IEnumerable<IContentSection> ContentSections { get; private set; }

		public IFooterComponent Footer { get; private set; }

		public void NavigateToPage()
		{
			if(this.Driver.Url != _url)
			{
				this.Driver.Url = _url;
				this.Driver.Navigate();
			}
		}
	}
}
