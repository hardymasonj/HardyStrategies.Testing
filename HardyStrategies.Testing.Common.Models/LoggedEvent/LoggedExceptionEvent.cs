using HardyStrategies.Testing.Common.Enumeration.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardyStrategies.Testing.Common.Models.LoggedEvents
{
	public class LoggedExceptionEvent : ILoggedEvent
	{
		public string TestName { get; private set; }
		public LogLevel LogLevel { get; private set; }
		public DateTime Timestamp { get; private set; }
		public string ResultDescription { get; private set; }
		public string StackTrace { get; private set; }
		public LoggedExceptionEvent(object oTest, string strMethodName, Exception ex)
		{
			this.TestName = $"{oTest.GetType().FullName}.{strMethodName}";
			this.LogLevel = LogLevel.ApplicationError;
			this.Timestamp = DateTime.UtcNow;
			this.ResultDescription = ex.Message;
			this.StackTrace = ex.StackTrace;
		}
	}
}
