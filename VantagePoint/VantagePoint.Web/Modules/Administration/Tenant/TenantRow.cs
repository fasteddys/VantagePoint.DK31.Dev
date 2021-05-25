
namespace VantagePoint.Administration.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Administration"), TableName("[public].[Tenant]")]
    [DisplayName("Tenant"), InstanceName("Tenant")]
    [ReadPermission(PermissionKeys.Tenant)]
    [ModifyPermission(PermissionKeys.Tenant)]
    [LookupScript("Administration.Tenant")]
    public sealed class TenantRow : Row, INameRow, IIdRow
    {
        [DisplayName("Tenant Id"), PrimaryKey]
        public Guid TenantId
        {
            get { return (Guid)Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Name"), Size(90), NotNull, QuickSearch, LookupInclude]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Tier"), Size(90), NotNull]
        public String Tier
        {
            get { return Fields.Tier[this]; }
            set { Fields.Tier[this] = value; }
        }

        [DisplayName("Domain"), Size(90), NotNull]
        public String Domain
        {
            get { return Fields.Domain[this]; }
            set { Fields.Domain[this] = value; }
        }

        [DisplayName("Created"), NotNull]
        public DateTime? Created
        {
            get { return Fields.Created[this]; }
            set { Fields.Created[this] = value; }
        }

        [DisplayName("Modified")]
        public DateTime? Modified
        {
            get { return Fields.Modified[this]; }
            set { Fields.Modified[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.TenantId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TenantRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public GuidField TenantId;
            public StringField Name;
            public StringField Tier;
            public StringField Domain;
            public DateTimeField Created;
            public DateTimeField Modified;
        }
    }
}
