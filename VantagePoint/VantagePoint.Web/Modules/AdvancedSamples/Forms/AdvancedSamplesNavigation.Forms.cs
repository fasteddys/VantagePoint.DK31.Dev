using Serenity.Navigation;
using VantagePoint.AdvancedSamples.Pages;

[assembly: NavigationMenu(7951, "Advanced Samples/Forms")]
[assembly: NavigationLink(7951, "Advanced Samples/Forms/Bootstrap Form", typeof(AdvancedSamplesController), action: "BootstrapFormList")]
[assembly: NavigationLink(7951, "Advanced Samples/Forms/Entity Grid Dialog", typeof(AdvancedSamplesController), action: "EntityGridDialog")]
[assembly: NavigationLink(7951, "Advanced Samples/Forms/Order Wizard", typeof(AdvancedSamplesController), action: "OrderWizard")]