using Microsoft.AspNetCore.Mvc;
using VantagePoint.Northwind.Entities;
using Serenity.Data;
using Views = MVC.Views.AdvancedSamples.DataTables;

namespace VantagePoint.AdvancedSamples.Pages
{
    public partial class AdvancedSamplesController : Controller
    {
        public ActionResult BasicInit()
        {
            using (var connection = SqlConnections.NewFor<CustomerRow>())
            {
                var c = CustomerRow.Fields;
                var model = connection.List<CustomerRow>(q => q
                    .Select(c.ID)
                    .Select(c.CustomerID)
                    .Select(c.CompanyName)
                    .Select(c.ContactName)
                    .Select(c.ContactTitle)
                    .Select(c.Country)
                    .Select(c.City));

                return View(Views.BasicInit, model);
            }
        }

        public ActionResult ServerSide()
        {
            return View(Views.ServerSide);
        }

        public ActionResult ServerSideSource()
        {
            var response = new DataTablesResponse();
            using (var connection = SqlConnections.NewFor<CustomerRow>())
            {
                var c = CustomerRow.Fields;
                var row = new CustomerRow();
                var query = new SqlQuery()
                    .Dialect(connection.GetDialect())
                    .From(row)
                    .Select(c.ID)
                    .Select(c.CustomerID)
                    .Select(c.CompanyName)
                    .Select(c.ContactName)
                    .Select(c.ContactTitle)
                    .Select(c.Country)
                    .Select(c.City)
                    .OrderBy(c.ID);

                int sort = 0;
                while (true)
                {
                    var ord = "order[" + sort++ + "]";
                    var colidx = Request.Form[ord + "[column]"];
                    if (string.IsNullOrEmpty(colidx))
                        break;

                    var idx = int.Parse(colidx);

                    var colkey = Request.Form["columns[" + idx + "][data]"];
                    if (string.IsNullOrEmpty(colkey))
                        continue;

                    query.OrderByFirst(colkey, Request.Form[ord + "[dir]"] == "desc");
                }

                var search = Request.Form["search[value]"];
                if (!string.IsNullOrEmpty(search))
                    query.Where(
                        c.CustomerID.Contains(search) |
                        c.CompanyName.Contains(search) |
                        c.ContactName.Contains(search));

                query.CountRecords = true;
                query.Skip(int.Parse((string)Request.Form["start"] ?? "0"));
                query.Take(int.Parse((string)Request.Form["length"] ?? "10"));

                response.recordsTotal = query.ForEach(connection, () =>
                {
                    response.data.Add(new
                    {
                        row.ID,
                        row.CustomerID,
                        row.CompanyName,
                        row.ContactName,
                        row.ContactTitle,
                        row.Country,
                        row.City
                    });
                });

                response.recordsFiltered = response.recordsTotal;
                response.draw = int.Parse(Request.Form["draw"]);
            }

            return new JsonResult(response);
        }

    }
}