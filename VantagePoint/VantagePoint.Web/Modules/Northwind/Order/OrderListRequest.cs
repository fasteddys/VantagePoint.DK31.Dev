using Serenity.Services;

namespace VantagePoint.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}