using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VantagePoint.AdvancedSamples
{
    public class BootstrapFormViewModel
    {
        [Required, Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public bool Discontinued { get; set; }
        [Display(Name = "Supplier")]
        public int? SupplierID { get; set; }
        [Display(Name = "Category")]
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
    }
}