using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace VantagePoint.Organization.Columns
{
    [ColumnsScript("Organization.Contact")]
    [BasedOnRow(typeof(Entities.ContactRow), CheckNames = true)]
    public class ContactColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ContactId { get; set; }
        [EditLink]
        public String Title { get; set; }
        [EditLink]
        public String FirstName { get; set; }
        [EditLink]
        public String LastName { get; set; }
        public String Email { get; set; }
        public String IdentityNo { get; set; }
        public String UserDisplayName { get; set; }
    }
}