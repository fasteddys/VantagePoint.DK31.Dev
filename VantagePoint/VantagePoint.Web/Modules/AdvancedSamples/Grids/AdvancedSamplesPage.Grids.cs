using Microsoft.AspNetCore.Mvc;
using Views = MVC.Views.AdvancedSamples.Grids;

namespace VantagePoint.AdvancedSamples.Pages
{
    public partial class AdvancedSamplesController : Controller
    {
        public ActionResult AutoColumnWidth()
        {
            return View(Views.AutoColumnWidth.Index);
        }

        public ActionResult CustomizableSummaries()
        {
            return View(Views.CustomizableSummaries.Index);
        }

        public ActionResult DragDropGrouping()
        {
            return View(Views.DragDropGrouping.Index);
        }

        public ActionResult ExcelStyleFilters()
        {
            return View(Views.ExcelStyleFilters.Index);
        }

        public ActionResult SplitMasterDetail()
        {
            return View(Views.SplitMasterDetail.Index);
        }
    }
}