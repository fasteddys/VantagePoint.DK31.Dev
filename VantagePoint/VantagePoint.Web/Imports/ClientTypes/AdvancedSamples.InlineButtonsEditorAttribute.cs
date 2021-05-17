using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace VantagePoint.AdvancedSamples
{
    public partial class InlineButtonsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "VantagePoint.AdvancedSamples.InlineButtonsEditor";

        public InlineButtonsEditorAttribute()
            : base(Key)
        {
        }
    }
}
