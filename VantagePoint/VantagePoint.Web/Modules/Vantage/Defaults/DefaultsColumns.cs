
namespace VantagePoint.Vantage.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Vantage.Defaults")]
    [BasedOnRow(typeof(Entities.DefaultsRow), CheckNames = true)]
    public class DefaultsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String Name { get; set; }
        public String Datatype { get; set; }
        public String Value { get; set; }
        public String Class { get; set; }
        public String Scope { get; set; }
    }
}