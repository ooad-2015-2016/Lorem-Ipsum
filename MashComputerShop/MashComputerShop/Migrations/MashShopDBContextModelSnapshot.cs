using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using MashComputerShop.MashShopDB.Models;

namespace MashComputerShopMigrations
{
    [ContextType(typeof(MashShopDBContext))]
    partial class MashShopDBContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("MashComputerShop.MashShopDB.Models.Administrator", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("JMBG");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<byte[]>("ProfileImage")
                        .Annotation("Relational:ColumnType", "image");

                    b.Property<decimal>("Salary");

                    b.Property<string>("TelephoneNumber");

                    b.Property<int>("UserID");

                    b.Property<string>("Username");

                    b.Key("AdminID");
                });

            builder.Entity("MashComputerShop.MashShopDB.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("Grade");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("QuantityInStorage");

                    b.Key("ProductID");
                });

            builder.Entity("MashComputerShop.MashShopDB.Models.RegisteredUser", b =>
                {
                    b.Property<int>("RegUserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<byte[]>("ProfileImage")
                        .Annotation("Relational:ColumnType", "image");

                    b.Property<string>("TelephoneNumber");

                    b.Property<int>("UserID");

                    b.Property<string>("Username");

                    b.Key("RegUserID");
                });
        }
    }
}
