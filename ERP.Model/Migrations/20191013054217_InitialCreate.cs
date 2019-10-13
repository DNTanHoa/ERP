using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Model.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    Oid = table.Column<Guid>(nullable: false),
                    OptimisticLockField = table.Column<int>(nullable: false),
                    createDate = table.Column<DateTime>(nullable: false),
                    updateDate = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.Oid);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Oid = table.Column<Guid>(nullable: false),
                    OptimisticLockField = table.Column<int>(nullable: false),
                    createDate = table.Column<DateTime>(nullable: false),
                    updateDate = table.Column<DateTime>(nullable: false),
                    username = table.Column<string>(nullable: true),
                    storedPassword = table.Column<string>(nullable: true),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Oid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
