using VantagePoint.Administration;
using Serenity;
using Serenity.Data;
using Serenity.Web;
using System;

namespace VantagePoint.Administration
{

    public class MultiTenantRowLookupScript<TRow> :
        RowLookupScript<TRow>
        where TRow : Row, IMultiTenantRow, new()
    {
        public MultiTenantRowLookupScript()
        {
            Expiration = TimeSpan.FromDays(-1);
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            AddTenantFilter(query);
        }

        protected void AddTenantFilter(SqlQuery query)
        {
            var r = new TRow();

            // VP1: (Fix) Handling null UserDefinition
            if (((UserDefinition)Authorization.UserDefinition) is null)
                return; //

            // VP1: (Fix) Allowing Root Admins to show all data
            if (!Authorization.HasPermission(PermissionKeys.Tenant)) //
                query.Where(r.TenantId == 
                ((UserDefinition)Authorization.UserDefinition).TenantId);
        }

        public override string GetScript()
        {
            // VP1: (Fix) Handling null UserDefinition
                if (((UserDefinition)Authorization.UserDefinition) is null)
                    return base.GetScript(); //

                return TwoLevelCache.GetLocalStoreOnly("MultiTenantLookup:" +
                        this.ScriptName + ":" +
                        ((UserDefinition)Authorization.UserDefinition).TenantId,
                        TimeSpan.FromHours(1),
                    new TRow().GetFields().GenerationKey, () =>
                    {
                        return base.GetScript();
                    });
            }


        }
    }

