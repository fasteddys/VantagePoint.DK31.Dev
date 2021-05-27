
namespace VantagePoint.Vantage.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.DefaultsRow))]
    public class DefaultsController : Controller
    {
        [Route("Vantage/Defaults")]
        public ActionResult Index()
        {
            return View("~/Modules/Vantage/Defaults/DefaultsIndex.cshtml");
        }
    }
}