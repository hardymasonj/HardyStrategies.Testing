using HardyStrategies.Testing.Common.Models.LoggedEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardyStrategies.Testing.Common.Models.Loggers
{
	public interface IEventLog
	{
		IEnumerable<ILoggedEvent> Events { get; }
		void AddEventToLog(ILoggedEvent oEvent);
		void WriteLogFile();
	}
}
