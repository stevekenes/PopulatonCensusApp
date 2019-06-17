using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CensusApp.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 25, nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<string>(nullable: false),
                    Occupation = table.Column<string>(nullable: false),
                    ResidentialAdress = table.Column<string>(maxLength: 100, nullable: false),
                    HomeTown = table.Column<string>(nullable: false),
                    LGAOfOrigin = table.Column<string>(nullable: false),
                    StateOfOrigin = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateCreated", "DateOfBirth", "DateUpdated", "Email", "FirstName", "Gender", "HomeTown", "LGAOfOrigin", "LastName", "Occupation", "PhoneNumber", "ResidentialAdress", "StateOfOrigin" },
                values: new object[] { 1, new DateTime(2019, 6, 17, 11, 6, 31, 813, DateTimeKind.Local).AddTicks(4564), "02/04/1987", new DateTime(2019, 6, 17, 11, 6, 31, 814, DateTimeKind.Local).AddTicks(3416), "tony@gmail.com", "Anthony", "Male", "Oko", "Aguata", "Ikechukwu", "Civil Servant", 9034544532L, "Ikeja Lagos", "Anambra" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateCreated", "DateOfBirth", "DateUpdated", "Email", "FirstName", "Gender", "HomeTown", "LGAOfOrigin", "LastName", "Occupation", "PhoneNumber", "ResidentialAdress", "StateOfOrigin" },
                values: new object[] { 2, new DateTime(2019, 6, 17, 11, 6, 31, 814, DateTimeKind.Local).AddTicks(4471), "22/07/1989", new DateTime(2019, 6, 17, 11, 6, 31, 814, DateTimeKind.Local).AddTicks(4480), "omo@gmail.com", "Omoye", "Fale", "Alaba", "Ojo", "Adeleke", "Treader", 7034374532L, "Lekki Lagos", "Lagos" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateCreated", "DateOfBirth", "DateUpdated", "Email", "FirstName", "Gender", "HomeTown", "LGAOfOrigin", "LastName", "Occupation", "PhoneNumber", "ResidentialAdress", "StateOfOrigin" },
                values: new object[] { 3, new DateTime(2019, 6, 17, 11, 6, 31, 814, DateTimeKind.Local).AddTicks(4494), "13/10/1990", new DateTime(2019, 6, 17, 11, 6, 31, 814, DateTimeKind.Local).AddTicks(4494), "musa@gmail.com", "Adams", "Male", "Wuse", "Wuse", "Musa", "Farmer", 8093544532L, "Festac Lagos", "Abuja" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
