using Serenity.Services;
using System.Data;
using MyRow = VantagePoint.Administration.Entities.DataAuditLogRow;

namespace VantagePoint.Administration.Repositories
{
    public class DataAuditLogRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }
    }
}