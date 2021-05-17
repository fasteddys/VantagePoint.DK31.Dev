using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace VantagePoint.AdminLTE
{
    [PageAuthorize, Route("AdminLTE/Tables/[action]")]
    public class TablesController : Controller
    {
        public ActionResult SimpleTables()
        {
            return View(MVC.Views.AdminLTE.Tables.SimpleTables);
        }
    }
}