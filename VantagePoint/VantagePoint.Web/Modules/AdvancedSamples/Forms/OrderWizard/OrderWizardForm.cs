using VantagePoint.Northwind;
using VantagePoint.Northwind.Entities;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace VantagePoint.AdvancedSamples.Forms
{
    [FormScript("AdvancedSamples.OrderWizard")]
    [BasedOnRow(typeof(OrderRow))]
    public class OrderWizardForm
    {
        [Tab("Customer Selection")]

        [StaticTextBlock(HideLabel = true, IsHtml = true, Text = "<h4 class='text-blue'>Welcome to Order Wizard!</h4>" +
            "<p>Please select if you'll be creating a new customer or use an existing one.</p>" +
            "<p>If you choose to create a new customer, you'll be asked to enter customer details in next step.</p>" +
            "<p>&nbsp;</p>")]
        public string WelcomeMessage { get; set; }

        [DisplayName("Customer Type"), DefaultValue(OrderWizardCustomerType.New)]
        [RadioButtonEditor(typeof(OrderWizardCustomerType))]
        public OrderWizardCustomerType CustomerType { get; set; }
        [DisplayName("Customer"), ReadOnly(true), CustomerEditor]
        public String ExistingCustomerID { get; set; }

        [Tab("Customer Details")]
        [Category("Basic Info")]
        [DisplayName("Customer ID"), StringEditor, MaxLength(5), Required, OneThirdWidth]
        public String CustomerID { get; set; }
        [DisplayName("Company Name"), MaxLength(40), Required, TwoThirdWidth]
        public String CompanyName { get; set; }

        [Category("Contact"), HalfWidth(UntilNext = true)]
        [DisplayName("Contact Name"), MaxLength(30)]
        public String ContactName { get; set; }
        [DisplayName("Contact Title"), MaxLength(30)]
        public String ContactTitle { get; set; }
        [ResetFormWidth, LookupEditor(typeof(EmployeeRow), Multiple = true)]
        public List<Int32> Representatives { get; set; }

        [Category("Address")]
        [MaxLength(60)]
        public String Address { get; set; }
        [HalfWidth(UntilNext = true), MaxLength(15), LookupEditor(typeof(Northwind.Lookups.CustomerCountryLookup))]
        public String Country { get; set; }
        [LookupEditor(typeof(Northwind.Lookups.CustomerCityLookup), CascadeFrom = "Country"), MaxLength(15)]
        public String City { get; set; }
        [MaxLength(15)]
        public String Region { get; set; }
        [DisplayName("Postal Code"), MaxLength(10)]
        public String PostalCode { get; set; }
        [MaxLength(24)]
        public String Phone { get; set; }
        [MaxLength(24)]
        public String Fax { get; set; }

        [Tab("Order Info"), Category(null)]
        [DefaultValue("now"), ResetFormWidth]
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public Int32? EmployeeID { get; set; }

        [Tab("Order Details")]
        [Northwind.OrderDetailsEditor, LabelWidth("0")]
        public List<OrderDetailRow> DetailList { get; set; }

        [Tab("Shipping")]
        public String ShipName { get; set; }
        public String ShipAddress { get; set; }
        public String ShipCity { get; set; }
        public String ShipRegion { get; set; }
        public String ShipPostalCode { get; set; }
        public String ShipCountry { get; set; }
    }
}