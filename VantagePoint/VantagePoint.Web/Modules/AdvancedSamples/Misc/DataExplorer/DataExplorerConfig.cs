using Serenity.ComponentModel;
using System.Collections.Generic;

namespace VantagePoint.AdvancedSamples
{
    [SettingKey("DataExplorer"), SettingScope("Application")]
    public class DataExplorerConfig
    {
        public string[] IncludeConnections { get; set; }
        public string[] ExcludeConnections { get; set; }
        public Dictionary<string, string[]> ExcludeTables { get; set; }
    }
}