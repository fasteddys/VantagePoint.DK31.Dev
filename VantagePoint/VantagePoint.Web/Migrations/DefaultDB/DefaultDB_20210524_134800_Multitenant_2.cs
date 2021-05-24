using FluentMigrator;
using System;

namespace VantagePoint.Migrations.DefaultDB
{

    [Migration(20210524134800)]
    public class DefaultDB_20210524_134800_Multitenant_2 : AutoReversingMigration
    {
        public override void Up()
        {

            // Adding placeholder tenants for initialization

            Insert.IntoTable("Tenant")
               .Row(new
               {
                  Name = "Alpha",
                  Domain = "D1",
                  Tier = "1"
               });

            Insert.IntoTable("Tenant")
                 .Row(new
                 {
                     Name = "Beta",
                     Domain = "D1",
                     Tier = "1"
                 });

            Insert.IntoTable("Tenant")
                .Row(new
                {
                    Name = "Gamma",
                    Domain = "D1",
                    Tier = "1"
                });

        }
    }
}