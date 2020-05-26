using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TradeOffAPI.Migrations
{
    public partial class CreateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EamilId = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    DOB = table.Column<DateTime>(type: "Date", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
