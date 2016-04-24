using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace MashComputerShopMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            // Kreiranje table "Administrator"
            migration.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    AdminID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column(type: "TEXT", nullable: true),
                    FirstName = table.Column(type: "TEXT", nullable: true),
                    HireDate = table.Column(type: "TEXT", nullable: false),
                    JMBG = table.Column(type: "TEXT", nullable: true),
                    LastName = table.Column(type: "TEXT", nullable: true),
                    Password = table.Column(type: "TEXT", nullable: true),
                    ProfileImage = table.Column(type: "image", nullable: true),
                    Salary = table.Column(type: "TEXT", nullable: false),
                    TelephoneNumber = table.Column(type: "TEXT", nullable: true),
                    UserID = table.Column(type: "INTEGER", nullable: false),
                    Username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.AdminID);
                });

            // Kreiranje tablee "Product"
            migration.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column(type: "TEXT", nullable: true),
                    Grade = table.Column(type: "INTEGER", nullable: false),
                    Name = table.Column(type: "TEXT", nullable: true),
                    Price = table.Column(type: "REAL", nullable: false),
                    QuantityInStorage = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                });

            // Kreiranje tabele "RegisteredUser"
            migration.CreateTable(
                name: "RegisteredUser",
                columns: table => new
                {
                    RegUserID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column(type: "TEXT", nullable: true),
                    FirstName = table.Column(type: "TEXT", nullable: true),
                    LastName = table.Column(type: "TEXT", nullable: true),
                    Password = table.Column(type: "TEXT", nullable: true),
                    ProfileImage = table.Column(type: "image", nullable: true),
                    TelephoneNumber = table.Column(type: "TEXT", nullable: true),
                    UserID = table.Column(type: "INTEGER", nullable: false),
                    Username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredUser", x => x.RegUserID);
                });
        }


        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Administrator");
            migration.DropTable("Product");
            migration.DropTable("RegisteredUser");
        }
    }
}
