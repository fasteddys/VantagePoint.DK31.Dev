
namespace VantagePoint.Vantage.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Vantage.Defaults")]
    [BasedOnRow(typeof(Entities.DefaultsRow), CheckNames = true)]
    public class DefaultsForm
    {
        public String Name { get; set; }
        public String Datatype { get; set; }
        public String Value { get; set; }
        public String Class { get; set; }
        public String Scope { get; set; }
    }
}