using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using MyRepository = VantagePoint.Administration.Repositories.UserRoleRepository;
using MyRow = VantagePoint.Administration.Entities.UserRoleRow;

namespace VantagePoint.Administration.Endpoints
{
    [Route("Services/Administration/UserRole/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class UserRoleController : ServiceEndpoint
    {
        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, UserRoleUpdateRequest request)
        {
            return new MyRepository().Update(uow, request);
        }

        public UserRoleListResponse List(IDbConnection connection, UserRoleListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
