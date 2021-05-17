using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace VantagePoint.BasicSamples
{
    public partial class HardcodedValuesEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "VantagePoint.BasicSamples.HardcodedValuesEditor";

        public HardcodedValuesEditorAttribute()
            : base(Key)
        {
        }
    }
}
