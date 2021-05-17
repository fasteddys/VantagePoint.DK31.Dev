using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace VantagePoint.Organization.Columns
{
    [ColumnsScript("Organization.BusinessUnit")]
    [BasedOnRow(typeof(Entities.BusinessUnitRow), CheckNames = true)]
    public class BusinessUnitColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 UnitId { get; set; }
        [EditLink, Width(300)]
        public String Name { get; set; }
        [EditLink, Width(300)]
        public Int32 ParentUnitName { get; set; }
    }
}