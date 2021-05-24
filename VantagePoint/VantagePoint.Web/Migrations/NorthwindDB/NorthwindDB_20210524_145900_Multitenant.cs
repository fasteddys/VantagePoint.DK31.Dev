//using FluentMigrator;
//using Serenity.Data;
//using System;
//using VantagePoint.Northwind.Entities;

//namespace VantagePoint.Migrations.NorthwindDB
//{
//    [Migration(20210524145900)]
//    public class NorthwindDB_20210524_145900_Multitenant : AutoReversingMigration
//    {
//        public override void Up()
//        {
//            Alter.Table("Employees")
//                .AddColumn("TenantId").AsGuid()
//                    .NotNullable().WithDefaultValue(1);

//            Alter.Table("Categories")
//                .AddColumn("TenantId").AsGuid()
//                    .NotNullable().WithDefaultValue(1);

//            Alter.Table("Customers")
//                .AddColumn("TenantId").AsGuid()
//                    .NotNullable().WithDefaultValue(1);

//            Alter.Table("Shippers")
//                .AddColumn("TenantId").AsGuid()
//                    .NotNullable().WithDefaultValue(1);

//            Alter.Table("Suppliers")
//                .AddColumn("TenantId").AsGuid()
//                    .NotNullable().WithDefaultValue(1);

//            Alter.Table("Orders")
//                .AddColumn("TenantId").AsGuid()
//                    .NotNullable().WithDefaultValue(1);

//            Alter.Table("Products")
//                .AddColumn("TenantId").AsGuid()
//                    .NotNullable().WithDefaultValue(1);

//            Alter.Table("Region")
//                .AddColumn("TenantId").AsGuid()
//                    .NotNullable().WithDefaultValue(1);

//            Alter.Table("Territories")
//                .AddColumn("TenantId").AsGuid()
//                    .NotNullable().WithDefaultValue(1);
//        }
//    }
//}