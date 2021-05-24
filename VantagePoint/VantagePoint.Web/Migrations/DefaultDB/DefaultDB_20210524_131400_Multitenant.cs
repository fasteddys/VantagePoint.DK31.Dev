using FluentMigrator;
using System;

namespace VantagePoint.Migrations.DefaultDB
{

    [Migration(20210524131400)]
    public class DefaultDB_20210524_131400_Multitenant : AutoReversingMigration
    {
        public override void Up()
        {

            // Creating Tenant table


            Create.Table("Tenant")
                .WithColumn("TenantId").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
                .WithColumn("Name").AsString(90).NotNullable()
                .WithColumn("Tier").AsString(90).NotNullable()
                .WithColumn("Domain").AsString(90).NotNullable()
                .WithColumn("Created").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentUTCDateTime)
                .WithColumn("Modified").AsDateTime().Nullable()
              ;

        }
    }
}