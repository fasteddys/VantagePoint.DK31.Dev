using Serenity.ComponentModel;
using System;
using VantagePoint.Northwind.Entities;

namespace VantagePoint.Northwind.Annotations
{
    /// <summary>
    /// This is annotation sample for OrderRow. Annotation types 
    /// are normally not required, and you could put these attributes
    /// directly on OrderRow properties, but such an annotation type
    /// lets you to move out UI specific dependencies from the row,
    /// so that you could move OrderRow itself into a separate 
    /// class library, e.g. a DLL with just the entities, if desired.
    /// </summary>
    [AnnotationType(typeof(OrderRow))]
    public sealed class OrderRowAnnotations
    {
        [CustomerEditor]
        public String CustomerID { get; set; }

        [LookupEditor(typeof(EmployeeRow))]
        public Int32? EmployeeID { get; set; }

        [LookupEditor(typeof(ShipperRow))]
        public Int32? ShipVia { get; set; }
    }
}