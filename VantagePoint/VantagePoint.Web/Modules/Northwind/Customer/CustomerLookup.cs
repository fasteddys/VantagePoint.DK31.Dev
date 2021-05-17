using VantagePoint.Common.Entities;
using Serenity.ComponentModel;
using Serenity.Web;
using VantagePoint.Northwind.Entities;

namespace VantagePoint.Northwind.Lookups
{
    [LookupScript]
    public class CustomerLookup : RowLookupScript<CustomerRow>
    {
        public CustomerLookup()
        {
            IdField = CustomerRow.Fields.CustomerID.PropertyName;
            TextField = CustomerRow.Fields.CompanyName.PropertyName;
        }
    }
}