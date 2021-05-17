
using Serenity.Services;

namespace VantagePoint.AdvancedSamples
{
    public class DataExplorerConnection
    {
        public string Key { get; set; }
    }

    public class DataExplorerTable
    {
        public string Name { get; set; }
    }

    public class DataExplorerField
    {
        public string Name { get; set; }
    }

    public class DataExplorerListTablesRequest : ListRequest
    {
        public string ConnectionKey { get; set; }
    }

    public class DataExplorerListRequest : ListRequest
    {
        public string ConnectionKey { get; set; }
        public string TableName { get; set; }
    }
}