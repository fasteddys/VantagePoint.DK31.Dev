using FluentMigrator;
using System;

namespace VantagePoint.Migrations.DefaultDB
{

    [Migration(20210524170300)]
    public class DefaultDB_20210524_170300_Multitenant_3 : AutoReversingMigration
    {
        public override void Up()
        {

            // Inserting selector field (TenantId) into common tables

            Alter.Table("Users").AddColumn("TenantId").AsGuid().NotNullable().WithDefaultValue("222ce0a5-2b67-4471-9855-e30dc74838fd");
            Alter.Table("Roles").AddColumn("TenantId").AsGuid().NotNullable().WithDefaultValue("222ce0a5-2b67-4471-9855-e30dc74838fd");
            Alter.Table("Languages").AddColumn("TenantId").AsGuid().NotNullable().WithDefaultValue("222ce0a5-2b67-4471-9855-e30dc74838fd");

        }
    }
}