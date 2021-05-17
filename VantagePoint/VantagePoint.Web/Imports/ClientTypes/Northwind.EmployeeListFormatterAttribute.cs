using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace VantagePoint.Northwind
{
    public partial class EmployeeListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "VantagePoint.Northwind.EmployeeListFormatter";

        public EmployeeListFormatterAttribute()
            : base(Key)
        {
        }
    }
}
