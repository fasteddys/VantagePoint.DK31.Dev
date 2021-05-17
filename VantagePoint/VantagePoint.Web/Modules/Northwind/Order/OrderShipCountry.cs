using VantagePoint.BasicSamples.Entities;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;
using VantagePoint.Northwind.Entities;

namespace VantagePoint.Northwind.Lookups
{
    [LookupScript]
    public class OrderShipCountryLookup : RowLookupScript<Entities.OrderRow>
    {
        public OrderShipCountryLookup()
        {
            IdField = TextField = OrderRow.Fields.ShipCountry.PropertyName;
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = OrderRow.Fields;
            query.Distinct(true)
                .Select(fld.ShipCountry)
                .Where(
                    new Criteria(fld.ShipCountry) != "" &
                    new Criteria(fld.ShipCountry).IsNotNull());
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}