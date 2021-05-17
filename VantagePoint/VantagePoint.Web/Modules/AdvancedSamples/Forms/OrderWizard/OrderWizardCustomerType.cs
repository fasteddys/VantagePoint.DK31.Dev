
using System.ComponentModel;

namespace VantagePoint.AdvancedSamples.Forms
{
    public enum OrderWizardCustomerType
    {
        [Description("New Customer")]
        New = 1,
        [Description("Existing Customer")]
        Existing = 2
    }
}