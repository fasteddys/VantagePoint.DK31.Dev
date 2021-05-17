using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace VantagePoint.AdminLTE
{
    [PageAuthorize, Route("AdminLTE/Mailbox/[action]")]
    public class MailboxController : Controller
    {
        public ActionResult Inbox()
        {
            return View(MVC.Views.AdminLTE.Mailbox.Inbox);
        }

        public ActionResult Compose()
        {
            return View(MVC.Views.AdminLTE.Mailbox.Compose);
        }

        public ActionResult Read()
        {
            return View(MVC.Views.AdminLTE.Mailbox.Read);
        }
    }
}