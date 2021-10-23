using System;
using System.Collections.Generic;
using System.Text;

namespace HardyStrategies.Testing.Common.Models.Tests
{
	interface ITestModel
	{
		void Setup();
		void Run();
		void Teardown();
	}
}
