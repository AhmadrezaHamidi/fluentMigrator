using FluentMigrator;
using System;
using System.Xml.Linq;

namespace FluentMigratorSample.Migrations
{
    [Migration(202106280001)]
    public class InitialTables_202106280001 : Migration
    {
        public override void Down()
        {
   
        }

        public override void Up()
        {
            Create.Table("Flow")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .WithColumn("UniqeId").AsString(32).NotNullable().Unique()
                .WithColumn("CreatedAt").AsDateTime().NotNullable()
                .WithColumn("Version").AsString(20).NotNullable()
                .WithColumn("UserId").AsInt32().NotNullable()
                .WithColumn("FlowTypeId").AsInt32().NotNullable()
                .WithColumn("FlowTypeName").AsString(20).NotNullable()
                .WithColumn("FlowTypeTitle").AsString(20).NotNullable()
                ;

            Create.Table("FlowType")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("Name").AsString(32).NotNullable()
                .WithColumn("Title").AsString(32).NotNullable()
                .WithColumn("Period").AsInt32().NotNullable();


            Create.Table("FlowActivity")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .WithColumn("UniqeId").AsString(32).NotNullable().Unique()
                .WithColumn("PervioseId").AsInt32().NotNullable()
                .WithColumn("PervioseUniqeId").AsString(32).NotNullable()
                .WithColumn("CreatedAt").AsDateTime().NotNullable()
                .WithColumn("FlowId").AsInt32().NotNullable()
                .WithColumn("FlowUniqeId").AsString(32).NotNullable()
                .WithColumn("FlowActivityTypeId").AsInt32().NotNullable()
                .WithColumn("FlowActivityTypeName").AsString(32).NotNullable()
                .WithColumn("FlowActivityTypeTitle").AsString(32).NotNullable()
                .WithColumn("Priority").AsInt32().NotNullable()
                ;


            Create.Table("FlowActivityType")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .WithColumn("Name").AsString(32).NotNullable()
                .WithColumn("Title").AsString(32).NotNullable()
                .WithColumn("Priority").AsInt32().NotNullable()
               ;


            Create.Table("Status")
               .WithColumn("Id").AsInt32().PrimaryKey()
               .WithColumn("Name").AsString(32).NotNullable().Unique()
               .WithColumn("CreatedAt").AsDateTime().NotNullable()
               .WithColumn("StatusTypeId").AsInt32().NotNullable()
               .WithColumn("StatusTypeName").AsString(30).NotNullable()
               .WithColumn("StatusTypeTitle").AsString(32).NotNullable()
               .WithColumn("FlowActivityId").AsInt32().NotNullable()
               .WithColumn("FlowActivityUniqueId").AsString(32).NotNullable()
              ;



            Create.Table("StatusType")
              .WithColumn("Id").AsInt32().PrimaryKey()
              .WithColumn("Name").AsString(32).NotNullable().Unique()
              .WithColumn("Title").AsString(30).NotNullable()
             ;



        }
    }
}
