using Microsoft.AspNetCore.Mvc;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Services;
using System.Collections.Generic;
using System.Data;
using MyRepository = VantagePoint.Administration.Repositories.UserPermissionRepository;
using MyRow = VantagePoint.Administration.Entities.UserPermissionRow;

namespace VantagePoint.Administration.Endpoints
{
    [Route("Services/Administration/UserPermission/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class UserPermissionController : ServiceEndpoint
    {
        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, UserPermissionUpdateRequest request)
        {
            return new MyRepository().Update(uow, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, UserPermissionListRequest request)
        {
            return new MyRepository().List(connection, request);
        }

        public ListResponse<string> ListRolePermissions(IDbConnection connection, UserPermissionListRequest request)
        {
            return new MyRepository().ListRolePermissions(connection, request);
        }

        [DataScript("Administration.PermissionKeys")]
        public ListResponse<string> ListPermissionKeys()
        {
            return new MyRepository().ListPermissionKeys(includeRoles: false);
        }

        [DataScript("Administration.ImplicitPermissions"), NonAction]
        public Dictionary<string, HashSet<string>> ListImplicitPermissions()
        {
            return new MyRepository().ImplicitPermissions;
        }
    }
}