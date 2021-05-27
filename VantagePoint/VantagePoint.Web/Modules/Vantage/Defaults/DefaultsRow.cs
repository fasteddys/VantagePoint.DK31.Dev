
namespace VantagePoint.Vantage.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Vantage"), TableName("[public].[Defaults]")]
    [DisplayName("Defaults"), InstanceName("Defaults")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class DefaultsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Name"), Size(90), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Datatype"), Size(40), NotNull]
        public String Datatype
        {
            get { return Fields.Datatype[this]; }
            set { Fields.Datatype[this] = value; }
        }

        [DisplayName("Value"), Size(160), NotNull]
        public String Value
        {
            get { return Fields.Value[this]; }
            set { Fields.Value[this] = value; }
        }

        [DisplayName("Class"), Size(40), NotNull]
        public String Class
        {
            get { return Fields.Class[this]; }
            set { Fields.Class[this] = value; }
        }

        [DisplayName("Scope"), Size(90)]
        public String Scope
        {
            get { return Fields.Scope[this]; }
            set { Fields.Scope[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DefaultsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Datatype;
            public StringField Value;
            public StringField Class;
            public StringField Scope;
        }
    }
}
