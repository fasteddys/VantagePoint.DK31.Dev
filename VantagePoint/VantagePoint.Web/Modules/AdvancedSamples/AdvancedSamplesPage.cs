using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace VantagePoint.AdvancedSamples.Pages
{
    [PageAuthorize, Route("AdvancedSamples/[action]")]
    public partial class AdvancedSamplesController : Controller
    {
    }
}