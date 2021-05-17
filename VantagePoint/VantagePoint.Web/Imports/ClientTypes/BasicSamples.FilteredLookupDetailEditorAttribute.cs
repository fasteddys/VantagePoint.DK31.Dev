using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace VantagePoint.BasicSamples
{
    public partial class FilteredLookupDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "VantagePoint.BasicSamples.FilteredLookupDetailEditor";

        public FilteredLookupDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}
