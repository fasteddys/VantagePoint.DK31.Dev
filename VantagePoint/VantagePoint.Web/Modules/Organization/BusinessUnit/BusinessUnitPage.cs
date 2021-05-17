using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace VantagePoint.Organization.Pages
{
    [PageAuthorize(typeof(Entities.BusinessUnitRow))]
    public class BusinessUnitController : Controller
    {
        [Route("Organization/BusinessUnit")]
        public ActionResult Index()
        {
            return View("~/Modules/Organization/BusinessUnit/BusinessUnitIndex.cshtml");
        }
    }
}
