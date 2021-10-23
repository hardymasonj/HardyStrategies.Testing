using HardyStrategies.Testing.Common.Enumeration.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardyStrategies.Testing.Common.Models.LoggedEvents
{
	public interface ILoggedEvent
	{
		string TestName { get; }
		LogLevel LogLevel { get; }
		DateTime Timestamp { get; }
		string ResultDescription { get; }
		string StackTrace { get; }
	}
}
