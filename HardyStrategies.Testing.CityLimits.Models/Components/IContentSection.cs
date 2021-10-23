using System;
using System.Collections.Generic;
using System.Text;

namespace HardyStrategies.Testing.CityLimits.Models.Components
{
	public interface IContentSection
	{
		string Header { get; }
		IEnumerable<IContentBlock> ContentBlocks { get; }
	}
}
