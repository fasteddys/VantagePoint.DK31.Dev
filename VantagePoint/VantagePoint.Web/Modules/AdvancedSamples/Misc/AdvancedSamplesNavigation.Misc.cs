using Serenity.Navigation;
using VantagePoint.AdvancedSamples.Pages;

[assembly: NavigationMenu(7951, "Advanced Samples/Misc")]
[assembly: NavigationLink(7951, "Advanced Samples/Misc/Data Audit Log", typeof(VantagePoint.Administration.Pages.DataAuditLogController))]
[assembly: NavigationLink(7951, "Advanced Samples/Misc/Data Explorer", typeof(AdvancedSamplesController), action: "DataExplorer")]
[assembly: NavigationLink(7951, "Advanced Samples/Misc/E-mail Client (IMAP)", typeof(Serenity.EmailClient.Pages.EmailController), action: "Index")]
[assembly: NavigationLink(7951, "Advanced Samples/Misc/Idle (Session) Timeout", typeof(AdvancedSamplesController), action: "IdleTimeout")]
