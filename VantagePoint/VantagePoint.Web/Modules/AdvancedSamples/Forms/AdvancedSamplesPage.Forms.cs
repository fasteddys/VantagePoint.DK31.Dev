using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VantagePoint.Northwind.Entities;
using Serenity.Data;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using X.PagedList;
using X.PagedList.Mvc;
using Views = MVC.Views.AdvancedSamples.Forms;

namespace VantagePoint.AdvancedSamples.Pages
{
    public partial class AdvancedSamplesController : Controller
    {
        public ActionResult BootstrapFormList(int? productID, int? page)
        {
            ViewBag.ProductID = productID;
            using (var connection = SqlConnections.NewFor<CustomerRow>())
            {
                var pageIndex = (page ?? 1);
                var pageSize = 10;
                var p = ProductRow.Fields;
                var products = connection.List<ProductRow>(q => q
                    .SelectTableFields()
                    .Select(p.SupplierCompanyName)
                    .Select(p.CategoryName)
                    .OrderBy(p.ProductName)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                );
                var productCount = connection.Count<ProductRow>();
                ViewBag.PagedList = new StaticPagedList<ProductRow>(products, pageIndex, pageSize, productCount);
                return View(Views.BootstrapForm.BootstrapFormList, products);
            }
        }

        [HttpGet]
        [Route("~/AdvancedSamples/BootstrapFormEdit/{productID?}")]
        public ActionResult BootstrapFormEdit(int? productID)
        {
            using (var connection = SqlConnections.NewFor<CustomerRow>())
            {
                ProductRow product;
                if (productID == null)
                    product = new Northwind.Entities.ProductRow();
                else
                {
                    product = connection.TryById<ProductRow>(productID.Value, q =>
                        q.SelectTableFields());
                    if (product == null)
                        return NotFound();
                }

                ViewBag.SupplierID = GetSupplierList(connection, product.SupplierID);
                ViewBag.CategoryID = GetCategoryList(connection, product.CategoryID);
                ViewBag.ProductID = productID;
                var model = product.Adapt<BootstrapFormViewModel>();
                return View(Views.BootstrapForm.BootstrapFormEdit, model);
            }
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("~/AdvancedSamples/BootstrapFormEdit/{productID?}")]
        public ActionResult BootstrapFormSave(int? productID, BootstrapFormViewModel model)
        {
            using (var connection = SqlConnections.NewFor<CustomerRow>())
            {
                ProductRow oldProduct = null;
                if (productID != null)
                {
                    oldProduct = connection.ById<ProductRow>(productID.Value);
                    if (oldProduct == null)
                        return NotFound();
                }

                if (ModelState.IsValid)
                {
                    var product = model.Adapt<ProductRow>();
                    if (productID == null)
                    {
                        product.ClearAssignment(ProductRow.Fields.ProductID);
                        productID = (int)connection.InsertAndGetID(product);
                    }
                    else
                    {
                        product.ProductID = productID;
                        connection.UpdateById(product);
                    }

                    return RedirectToAction("BootstrapFormList");
                }
                else
                {
                    ViewBag.SupplierID = GetSupplierList(connection, model.SupplierID);
                    ViewBag.CategoryID = GetCategoryList(connection, model.CategoryID);
                    return View(Views.BootstrapForm.BootstrapFormEdit, model);
                }
            }
        }

        private IEnumerable<SelectListItem> GetCategoryList(IDbConnection connection, int? categoryID)
        {
            var cat = CategoryRow.Fields;
            return connection.List<CategoryRow>(q => q
                .Select(cat.CategoryID)
                .Select(cat.CategoryName)
                .OrderBy(cat.CategoryName))
            .Select(x => new SelectListItem
            {
                Value = x.CategoryID.Value.ToString(),
                Text = x.CategoryName,
                Selected = categoryID != null && x.CategoryID == categoryID
            });
        }

        private IEnumerable<SelectListItem> GetSupplierList(IDbConnection connection, int? supplierID)
        {
            var sup = SupplierRow.Fields;
            return connection.List<SupplierRow>(q => q
                .Select(sup.SupplierID)
                .Select(sup.CompanyName)
                .OrderBy(sup.CompanyName))
            .Select(x => new SelectListItem
            {
                Value = x.SupplierID.Value.ToString(),
                Text = x.CompanyName,
                Selected = supplierID != null && x.SupplierID == supplierID
            });
        }

        public ActionResult EntityGridDialog()
        {
            return View(Views.EntityGridDialog.Index);
        }

        public ActionResult OrderWizard()
        {
            return View(Views.OrderWizard.Index);
        }
    }
}