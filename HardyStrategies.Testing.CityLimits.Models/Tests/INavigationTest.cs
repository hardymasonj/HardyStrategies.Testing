using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardyStrategies.Testing.CityLimits.Models.Components;

namespace HardyStrategies.Testing.CityLimits.Models.Tests
{
	public interface INavigationTest
	{
		void TestRatesLink(INavigationComponent oNavComponent);
		void TestTrailersLink(INavigationComponent oNavComponent);
	}
}
