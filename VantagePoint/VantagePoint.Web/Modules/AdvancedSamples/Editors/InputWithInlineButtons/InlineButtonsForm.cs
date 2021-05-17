using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace VantagePoint.AdvancedSamples.Forms
{
    [FormScript("AdvancedSamples.InlineButtons")]
    public class InlineButtonsForm
    {
        [DisplayName("Some Text Input")]
        public string SomeTextInput { get; set; }

        [DisplayName("Input with Buttons"), InlineButtonsEditor]
        public string InputWithButton { get; set; }

        [DisplayName("Externally Created Button")]
        public int ExternallyCreatedButton { get; set; }

    }
}