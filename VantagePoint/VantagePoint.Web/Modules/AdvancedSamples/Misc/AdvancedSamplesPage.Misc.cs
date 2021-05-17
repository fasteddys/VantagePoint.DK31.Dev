using Microsoft.AspNetCore.Mvc;
using VantagePoint.Northwind.Entities;
using Serenity.Data;
using Views = MVC.Views.AdvancedSamples.Misc;

namespace VantagePoint.AdvancedSamples.Pages
{
    public partial class AdvancedSamplesController : Controller
    {
        public ActionResult DataExplorer()
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

                return View(Views.DataExplorer.DataExplorerIndex, model);
            }
        }

        public ActionResult IdleTimeout()
        {
            return View(Views.IdleTimeout.IdleTimeoutIndex);
        }
    }
}