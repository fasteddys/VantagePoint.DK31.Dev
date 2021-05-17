using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using MyRepository = VantagePoint.Common.Repositories.UserPreferenceRepository;
using MyRow = VantagePoint.Common.Entities.UserPreferenceRow;

namespace VantagePoint.Common.Endpoints
{
    [Route("Services/Common/UserPreference/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize]
    public class UserPreferenceController : ServiceEndpoint
    {
        [HttpPost]
        public ServiceResponse Update(IUnitOfWork uow, UserPreferenceUpdateRequest request)
        {
            return new MyRepository().Update(uow, request);
        }

        public UserPreferenceRetrieveResponse Retrieve(IDbConnection connection, UserPreferenceRetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }
    }
}
