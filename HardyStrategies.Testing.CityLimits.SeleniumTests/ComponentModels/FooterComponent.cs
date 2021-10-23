using HardyStrategies.Testing.CityLimits.Models.Components;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardyStrategies.Testing.CityLimits.SeleniumTests.ComponentModels
{
	public class FooterComponent : SeleniumComponentBase, IFooterComponent
	{
		public FooterComponent(IWebDriver oDriver) : base(oDriver, By.Id("footer"))
		{

		}
		private IWebElement GetFooterLinkByInnerText(string strInnerText)
		{
			return this.RootElement.FindElement(By.XPath($@"//a[contains(text(), '{strInnerText}')]"));
		}
		private IWebElement GetFooterLinkByAriaLabel(string strLabel)
		{
			return this.RootElement.FindElement(By.XPath($@"//a[@aria-label='{strLabel}']"));
		}
		public string GetCellPhoneNumberTarget()
		{
			var oContactUsElement = this.GetFooterLinkByInnerText("(218) 398-2776");
			return oContactUsElement.GetAttribute("href");
		}

		public string GetEmailTarget()
		{
			var oContactUsElement = this.GetFooterLinkByInnerText("grcitylimits@gmail.com");
			return oContactUsElement.GetAttribute("href");
		}

		public string GetPhoneNumberTarget()
		{
			var oContactUsElement = this.GetFooterLinkByInnerText("(218) 999-5900");
			return oContactUsElement.GetAttribute("href");
		}

		public void NavigateToFacebook()
		{
			var oFacebookLink = this.GetFooterLinkByAriaLabel("Facebook");
			oFacebookLink.Click();
		}

		public void NavigateToYelp()
		{
			var oYelpLink = this.GetFooterLinkByAriaLabel("Yelp");
			oYelpLink.Click();
		}
	}
}
