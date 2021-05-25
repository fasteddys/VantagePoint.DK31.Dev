
using Serenity.Extensibility;
using System.ComponentModel;

namespace VantagePoint.Administration
{
    [NestedPermissionKeys]
    [DisplayName("Administration")]
    public class PermissionKeys
    {
        [Description("User, Role Management and Permissions")]
        public const string Security = "Administration:Security";

        [Description("Languages and Translations")]
        public const string Translation = "Administration:Translation";

        [Description("Tenants, SaaS Tenants")]
        public const string Tenant = "Administration:Tenant";
    }
}
