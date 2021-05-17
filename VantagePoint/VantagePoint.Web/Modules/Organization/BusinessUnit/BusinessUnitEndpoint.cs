using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using MyRepository = VantagePoint.Organization.Repositories.BusinessUnitRepository;
using MyRow = VantagePoint.Organization.Entities.BusinessUnitRow;

namespace VantagePoint.Organization.Endpoints
{
    [Route("Services/Organization/BusinessUnit/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class BusinessUnitController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
