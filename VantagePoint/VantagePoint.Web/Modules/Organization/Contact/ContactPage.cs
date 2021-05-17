using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace VantagePoint.Organization.Pages
{
    [PageAuthorize(typeof(Entities.ContactRow))]
    public class ContactController : Controller
    {
        [Route("Organization/Contact")]
        public ActionResult Index()
        {
            return View("~/Modules/Organization/Contact/ContactIndex.cshtml");
        }
    }
}
