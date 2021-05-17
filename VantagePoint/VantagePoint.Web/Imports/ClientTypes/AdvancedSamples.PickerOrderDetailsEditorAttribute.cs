using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace VantagePoint.AdvancedSamples
{
    public partial class PickerOrderDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "VantagePoint.AdvancedSamples.PickerOrderDetailsEditor";

        public PickerOrderDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}
