using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace VantagePoint.AdvancedSamples.Forms
{
    [FormScript("AdvancedSamples.MultiDatesPicker")]
    public class MultiDatesPickerForm
    {
        [DisplayName("Multiple Dates"), MultiDatesPickerEditor]
        public string MultipleDates { get; set; }
        [DisplayName("Select Max 3 Dates"), MultiDatesPickerEditor(MaxPicks = 3)]
        public string Max3Dates { get; set; }
    }
}