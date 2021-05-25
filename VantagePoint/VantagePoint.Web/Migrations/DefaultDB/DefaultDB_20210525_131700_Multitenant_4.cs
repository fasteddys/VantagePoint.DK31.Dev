using FluentMigrator;
using System;

namespace VantagePoint.Migrations.DefaultDB
{

    [Migration(20210525131700)]
    public class DefaultDB_20210525_131700_Multitenant_4 : AutoReversingMigration
    {
        public override void Up()
        {

            // Removing default values that were needed just for initialization

            Alter.Table("Users").AlterColumn("TenantId").AsGuid().NotNullable();
            Alter.Table("Roles").AlterColumn("TenantId").AsGuid().NotNullable();
            Alter.Table("Languages").AlterColumn("TenantId").AsGuid().NotNullable();

        }
    }
}