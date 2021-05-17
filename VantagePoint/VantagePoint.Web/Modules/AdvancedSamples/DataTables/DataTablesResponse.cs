using System.Collections.Generic;

namespace VantagePoint.AdvancedSamples
{
    public class DataTablesResponse
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<object> data { get; set; }

        public DataTablesResponse()
        {
            data = new List<object>();
        }
    }
}