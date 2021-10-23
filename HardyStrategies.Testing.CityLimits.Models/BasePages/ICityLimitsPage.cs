using HardyStrategies.Testing.CityLimits.Models.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardyStrategies.Testing.CityLimits.Models.BasePages
{
	public interface ICityLimitsPage
	{
		void NavigateToPage();
		INavigationComponent Navigation { get; }
		IEnumerable<IContentSection> ContentSections { get; }
		IFooterComponent Footer { get; }
	}
}
