using FluentMigrator;
using System;

namespace PrototypeB.Migrations.DefaultDB
{

    [Migration(20201204165700)]
    public class DefaultDB_20201204_165700_Defaults : AutoReversingMigration
    {
        public override void Up()
        {

            // Application Configuration
            this.Create.Table("Defaults")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString(90).NotNullable()
                .WithColumn("Datatype").AsString(40).NotNullable()
                .WithColumn("Value").AsString(160).NotNullable()
                .WithColumn("Class").AsString(40).NotNullable()
                .WithColumn("Scope").AsString(90).Nullable() 
              ;

        }
    }
}