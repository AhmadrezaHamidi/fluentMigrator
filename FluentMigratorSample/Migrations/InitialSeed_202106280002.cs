using FluentMigrator;
using FluentMigratorSample.Entities;
using System.Collections.Generic;

namespace FluentMigratorSample.Migrations
{
    [Migration(202106280002)]
    public class InitialSeed_202106280002 : Migration
    {
        public override void Down()
        {
       
        }

        public override void Up()
        {
            Insert.IntoTable("FlowActivityType")
                .Row(new FlowActivityType() { Id = 1, Name = "TrStart", Title = "شروع کارت به کارت", Priority = 5 });

            Insert.IntoTable("FlowActivityType").Row(
                new FlowActivityType() { Id = 2, Name = "SelectCard", Title = "انتخاب کارت مبدا", Priority = 1 });

            Insert.IntoTable("FlowActivityType").Row(
                new FlowActivityType() { Id = 3, Name = "SelectDestCard", Title = "انتخاب کارت مقصد", Priority = 1 });

            Insert.IntoTable("FlowActivityType").Row(
                new FlowActivityType   ()  { Id = 4, Name = "TrFinish", Title = "پایان کارت به کارت", Priority = 1 }
                );





           

            Insert.IntoTable("FlowType")
                .Row(new FlowType {
                    Id = 1,
                    Name = "کارت به کارت ",
                    Title = "CardTransfer",
                    Period = 5
                });



            Insert.IntoTable("FlowType")
                .Row(new FlowType
                {
                    Id = 2,
                    Name = "موجودی کارت ",
                    Title = "CardBalance",
                    Period = 1
                });


            Insert.IntoTable("FlowType")
               .Row(new FlowType
               {
                   Id = 3,
                   Name = "گردش کارت ",
                   Title = "CardStatement",
                   Period = 1
               });


            Insert.IntoTable("StatusType")
               .Row(new StatusType
               {
                   Id = 1,
                   Name = "شروع",
                   Title = "Init",
               });

            Insert.IntoTable("StatusType")
             .Row(new StatusType
             {
                 Id = 2,
                 Name = "در حال انتظار",
                 Title = "Pending",
             });

            Insert.IntoTable("StatusType")
             .Row(new StatusType
             {
                 Id = 3,
                 Name = "تایید شده",
                 Title = "Success",
             });

            Insert.IntoTable("StatusType")
             .Row(new StatusType
             {
                 Id = 4,
                 Name = "خطا",
                 Title = "Fail",
             });
        }
    }
}
