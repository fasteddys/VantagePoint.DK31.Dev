using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace VantagePoint.AdvancedSamples
{
    public partial class MultiDatesPickerEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "VantagePoint.AdvancedSamples.MultiDatesPickerEditor";

        public MultiDatesPickerEditorAttribute()
            : base(Key)
        {
        }

        public String MaxDate
        {
            get { return GetOption<String>("maxDate"); }
            set { SetOption("maxDate", value); }
        }

        public Double MaxPicks
        {
            get { return GetOption<Double>("maxPicks"); }
            set { SetOption("maxPicks", value); }
        }

        public String MinDate
        {
            get { return GetOption<String>("minDate"); }
            set { SetOption("minDate", value); }
        }
    }
}

