using HardyStrategies.Testing.Common.Models.LoggedEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HardyStrategies.Testing.Common.Models.Loggers
{
	public class JSONFileEventLog : EventLogBase
	{
		public string FilePath { get; set; }
		public string FileName { get; private set; }
		public JSONFileEventLog(string strPath)
		{
			this.FilePath = strPath;
		}
		public override void WriteLogFile()
		{
			var strFullPath = this.FileName;
			if (string.IsNullOrWhiteSpace(this.FileName))
			{
				this.FileName = $"EventLog_{DateTime.Now.ToString("yyyy-MM-dd_HHmmss")}.json";
			}
			strFullPath = System.IO.Path.Combine(this.FilePath);
			System.IO.File.WriteAllText(strFullPath, JsonConvert.SerializeObject(this.Events));
		}
	}
}
