using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using MyRepository = VantagePoint.Northwind.Repositories.SalesByCategoryRepository;
using MyRow = VantagePoint.Northwind.Entities.SalesByCategoryRow;

namespace VantagePoint.Northwind.Endpoints
{
    [Route("Services/Northwind/SalesByCategory/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class SalesByCategoryController : ServiceEndpoint
    {
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
