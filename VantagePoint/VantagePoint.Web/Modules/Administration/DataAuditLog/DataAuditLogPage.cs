using Microsoft.AspNetCore.Mvc;
using Serenity;
using Serenity.Data;
using Serenity.Web;
using System;
using System.Collections.Generic;

namespace VantagePoint.Administration.Pages
{
    [PageAuthorize(typeof(Entities.DataAuditLogRow))]
    public class DataAuditLogController : Controller
    {
        [Route("Administration/DataAuditLog")]
        public ActionResult Index()
        {
            if (Administration.Repositories.UserRepository.isPublicDemo &&
                Serenity.Authorization.Username == "admin")
            {
                using (var connection = SqlConnections.NewFor<Administration.Entities.DataAuditLogRow>())
                {

                    if (!new SqlQuery()
                        .From(Entities.DataAuditLogRow.Fields)
                        .Select("1")
                        .Take(1)
                        .Exists(connection))
                    {
                        using (var cnn = SqlConnections.NewFor<Northwind.Entities.OrderRow>())
                        using (var uow = new UnitOfWork(cnn))
                        {
                            var productId = cnn.First<Northwind.Entities.ProductRow>((ICriteria)null).ProductID;
                            var orderId = Convert.ToInt32(new Northwind.Repositories.OrderRepository().Create(uow,
                                new Serenity.Services.SaveRequest<Northwind.Entities.OrderRow>
                                {
                                    Entity = new Northwind.Entities.OrderRow
                                    {
                                        CustomerID = cnn.First<Northwind.Entities.CustomerRow>((ICriteria)null).CustomerID,
                                        OrderDate = DateTime.Today,
                                        DetailList = new List<Northwind.Entities.OrderDetailRow>
                                        {
                                            new Northwind.Entities.OrderDetailRow
                                            {
                                                ProductID = productId,
                                                UnitPrice = 1357,
                                                Quantity = 1
                                            }
                                        }
                                    }
                                }).EntityId);

                            new Northwind.Repositories.OrderRepository().Update(uow,
                                new Serenity.Services.SaveRequest<Northwind.Entities.OrderRow>
                                {
                                    EntityId = orderId,
                                    Entity = new Northwind.Entities.OrderRow
                                    {
                                        ShippedDate = DateTime.UtcNow
                                    }
                                });

                            new Northwind.Repositories.OrderRepository().Delete(uow,
                                new Serenity.Services.DeleteRequest
                                {
                                    EntityId = orderId
                                });

                            uow.Commit();
                        }
                    }
                }
            }

            return View("~/Modules/Administration/DataAuditLog/DataAuditLogIndex.cshtml");
        }
    }
}
