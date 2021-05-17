using Microsoft.AspNetCore.Mvc;
using Views = MVC.Views.AdvancedSamples.Editors;

namespace VantagePoint.AdvancedSamples.Pages
{
    public partial class AdvancedSamplesController : Controller
    {
        public ActionResult InputWithInlineButtons()
        {
            return View(Views.InputWithInlineButtons.Index);
        }

        public ActionResult MultiDatesPicker()
        {
            return View(Views.MultiDatesPicker.Index);
        }

        public ActionResult ProductPicker()
        {
            return View(Views.ProductPicker.Index);
        }
    }
}