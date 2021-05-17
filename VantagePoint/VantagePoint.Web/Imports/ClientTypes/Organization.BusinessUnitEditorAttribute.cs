using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace VantagePoint.Organization
{
    public partial class BusinessUnitEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "VantagePoint.Organization.BusinessUnitEditor";

        public BusinessUnitEditorAttribute()
            : base(Key)
        {
        }
    }
}
