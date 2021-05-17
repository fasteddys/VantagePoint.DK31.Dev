using Serenity.ComponentModel;
using System;

namespace VantagePoint.Organization.Forms
{
    [FormScript("Organization.BusinessUnit")]
    [BasedOnRow(typeof(Entities.BusinessUnitRow), CheckNames = true)]
    public class BusinessUnitForm
    {
        public String Name { get; set; }
        public Int32 ParentUnitId { get; set; }
    }
}