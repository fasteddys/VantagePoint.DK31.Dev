using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace VantagePoint.BasicSamples.Pages
{
    [PageAuthorize, Route("BasicSamples/[action]")]
    public partial class BasicSamplesController : Controller
    {
    }
}
