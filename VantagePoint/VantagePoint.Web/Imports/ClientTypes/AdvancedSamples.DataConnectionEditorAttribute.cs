using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace VantagePoint.AdvancedSamples
{
    public partial class DataConnectionEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "VantagePoint.AdvancedSamples.DataConnectionEditor";

        public DataConnectionEditorAttribute()
            : base(Key)
        {
        }
    }
}
