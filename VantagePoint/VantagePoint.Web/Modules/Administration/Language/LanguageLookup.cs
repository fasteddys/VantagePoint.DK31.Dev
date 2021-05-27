using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;
using VantagePoint.Administration.Entities;

namespace VantagePoint.Administration.Lookups
{
    [LookupScript] // VP1: Multitenant Lookup Script
    public sealed class LanguageLookup : MultiTenantRowLookupScript<LanguageRow> //
    {
        public LanguageLookup()
        {
            IdField = LanguageRow.Fields.LanguageId.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            query.Select(LanguageRow.Fields.LanguageId);

            //VP1: Multitenant Lookup Script
            AddTenantFilter(query); //
        }
    }
}