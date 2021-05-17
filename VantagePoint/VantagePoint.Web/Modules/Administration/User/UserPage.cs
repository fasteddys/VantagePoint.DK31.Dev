using Microsoft.AspNetCore.Mvc;
using Serenity.Web;
using StackExchange.Exceptional;
using System.Threading.Tasks;

namespace VantagePoint.Administration.Pages
{
    [PageAuthorize(typeof(Entities.UserRow))]
    public class UserController : Controller
    {
        [Route("Administration/User")]
        public ActionResult Index()
        {
            return View(MVC.Views.Administration.User.UserIndex);
        }

        [Route("Administration/ExceptionLog/{*pathInfo}"), IgnoreAntiforgeryToken]
        public async Task ExceptionLog()
        {
            await ExceptionalMiddleware.HandleRequestAsync(HttpContext).ConfigureAwait(false);
        }
    }
}