using System;
using System.Collections.Generic;
using System.Text;

namespace HardyStrategies.Testing.CityLimits.Models.Components
{
	public interface INavigationComponent
	{
		void NavigateToRates();
		void NavigateToLocations();
		void NavigateToTrailers();
		void NavigateToNews();
		void NavigateToPayBills();

	}
}
