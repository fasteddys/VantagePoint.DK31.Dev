﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using VantagePoint.Administration;

namespace VantagePoint.Administration
{
    public class MultiTenantBehavior: IImplicitBehavior,
        ISaveBehavior, IDeleteBehavior,
        IListBehavior, IRetrieveBehavior
    {
        private GuidField fldTenantId;

        public bool ActivateFor(Row row)
        {
            var mt = row as IMultiTenantRow;
            if (mt == null)
                return false;

            fldTenantId = mt.TenantId;
            return true;
        }

        public void OnPrepareQuery(IRetrieveRequestHandler handler,
            SqlQuery query)
        {
            var user = (UserDefinition)Authorization.UserDefinition;
            if (!Authorization.HasPermission(PermissionKeys.Tenant))
                query.Where(fldTenantId == user.TenantId);
        }

        public void OnPrepareQuery(IListRequestHandler handler,
            SqlQuery query)
        {
            var user = (UserDefinition)Authorization.UserDefinition;
            if (!Authorization.HasPermission(PermissionKeys.Tenant))
                query.Where(fldTenantId == user.TenantId);
        }

        public void OnSetInternalFields(ISaveRequestHandler handler)
        {
            if (handler.IsCreate)
                fldTenantId[handler.Row] =
                    ((UserDefinition)Authorization
                        .UserDefinition).TenantId;
        }

        public void OnValidateRequest(ISaveRequestHandler handler)
        {
            if (handler.IsUpdate)
            {
                var user = (UserDefinition)Authorization.UserDefinition;
                if (fldTenantId[handler.Old] != fldTenantId[handler.Row])
                    Authorization.ValidatePermission(PermissionKeys.Tenant);
            }
        }

        public void OnValidateRequest(IDeleteRequestHandler handler)
        {
            var user = (UserDefinition)Authorization.UserDefinition;
            if (fldTenantId[handler.Row] != user.TenantId)
                Authorization.ValidatePermission(
                    PermissionKeys.Tenant);
        }

        public void OnAfterDelete(IDeleteRequestHandler handler) { }
        public void OnAfterExecuteQuery(IRetrieveRequestHandler handler) { }
        public void OnAfterExecuteQuery(IListRequestHandler handler) { }
        public void OnAfterSave(ISaveRequestHandler handler) { }
        public void OnApplyFilters(IListRequestHandler handler, SqlQuery query) { }
        public void OnAudit(IDeleteRequestHandler handler) { }
        public void OnAudit(ISaveRequestHandler handler) { }
        public void OnBeforeDelete(IDeleteRequestHandler handler) { }
        public void OnBeforeExecuteQuery(IRetrieveRequestHandler handler) { }
        public void OnBeforeExecuteQuery(IListRequestHandler handler) { }
        public void OnBeforeSave(ISaveRequestHandler handler) { }
        public void OnPrepareQuery(IDeleteRequestHandler handler, SqlQuery query) { }
        public void OnPrepareQuery(ISaveRequestHandler handler, SqlQuery query) { }
        public void OnReturn(IDeleteRequestHandler handler) { }
        public void OnReturn(IRetrieveRequestHandler handler) { }
        public void OnReturn(IListRequestHandler handler) { }
        public void OnReturn(ISaveRequestHandler handler) { }
        public void OnValidateRequest(IRetrieveRequestHandler handler) { }
        public void OnValidateRequest(IListRequestHandler handler) { }
    }
}
