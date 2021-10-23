using HardyStrategies.Testing.Common.Models.LoggedEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardyStrategies.Testing.Common.Models.Loggers
{
	public abstract class EventLogBase : IEventLog
	{
		protected List<ILoggedEvent> _Events = new List<ILoggedEvent>();
		public IEnumerable<ILoggedEvent> Events => _Events;
		public void AddEventToLog(ILoggedEvent oEvent)
		{
			this._Events.Add(oEvent);
		}
		public abstract void WriteLogFile();
	}
}
