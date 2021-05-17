using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace VantagePoint.AdvancedSamples.Forms
{
    [FormScript("AdvancedSamples.PickerOrder")]
    [BasedOnRow(typeof(Northwind.Entities.OrderRow), CheckNames = true)]
    public class PickerOrderForm
    {
        [Category("Order")]
        public String CustomerID { get; set; }
        [DefaultValue("now")]
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public Int32? EmployeeID { get; set; }

        [Category("Order Details")]
        [PickerOrderDetailsEditor]
        public List<Northwind.Entities.OrderDetailRow> DetailList { get; set; }

        [Category("Shipping")]
        public DateTime ShippedDate { get; set; }
        public Int32 ShipVia { get; set; }
        public Decimal Freight { get; set; }

        [Category("Ship To")]
        public String ShipName { get; set; }
        public String ShipAddress { get; set; }
        public String ShipCity { get; set; }
        public String ShipRegion { get; set; }
        public String ShipPostalCode { get; set; }
        public String ShipCountry { get; set; }
    }
}