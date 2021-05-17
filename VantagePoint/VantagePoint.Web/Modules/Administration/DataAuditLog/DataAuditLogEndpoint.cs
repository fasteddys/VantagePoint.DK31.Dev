using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using MyRepository = VantagePoint.Administration.Repositories.DataAuditLogRepository;
using MyRow = VantagePoint.Administration.Entities.DataAuditLogRow;

namespace VantagePoint.Administration.Endpoints
{
    [Route("Services/Administration/DataAuditLog/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class DataAuditLogController : ServiceEndpoint
    {
        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
