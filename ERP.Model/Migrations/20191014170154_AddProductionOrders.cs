using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Model.Migrations
{
    public partial class AddProductionOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UsersOid",
                table: "role",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Oid = table.Column<Guid>(nullable: false),
                    OptimisticLockField = table.Column<int>(nullable: true),
                    createDate = table.Column<DateTime>(nullable: false),
                    updateDate = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    representative = table.Column<string>(nullable: true),
                    representativePhone = table.Column<string>(nullable: true),
                    representativeEmail = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    taxCode = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Oid);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Oid = table.Column<Guid>(nullable: false),
                    OptimisticLockField = table.Column<int>(nullable: true),
                    createDate = table.Column<DateTime>(nullable: false),
                    updateDate = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Oid);
                });

            migrationBuilder.CreateTable(
                name: "productionOrdersStatus",
                columns: table => new
                {
                    Oid = table.Column<Guid>(nullable: false),
                    OptimisticLockField = table.Column<int>(nullable: true),
                    createDate = table.Column<DateTime>(nullable: false),
                    updateDate = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    code = table.Column<string>(maxLength: 3, nullable: true),
                    note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productionOrdersStatus", x => x.Oid);
                });

            migrationBuilder.CreateTable(
                name: "productionOrders",
                columns: table => new
                {
                    Oid = table.Column<Guid>(nullable: false),
                    OptimisticLockField = table.Column<int>(nullable: true),
                    createDate = table.Column<DateTime>(nullable: false),
                    updateDate = table.Column<DateTime>(nullable: false),
                    code = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    deadline = table.Column<DateTime>(nullable: true),
                    startDate = table.Column<DateTime>(nullable: true),
                    finishDate = table.Column<DateTime>(nullable: true),
                    supervisorOid = table.Column<Guid>(nullable: false),
                    customerOid = table.Column<Guid>(nullable: true),
                    version = table.Column<string>(maxLength: 5, nullable: true),
                    productionStatusOid = table.Column<Guid>(nullable: false),
                    isLate = table.Column<bool>(nullable: false),
                    note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productionOrders", x => x.Oid);
                    table.ForeignKey(
                        name: "FK_productionOrders_customers_customerOid",
                        column: x => x.customerOid,
                        principalTable: "customers",
                        principalColumn: "Oid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productionOrders_productionOrdersStatus_productionStatusOid",
                        column: x => x.productionStatusOid,
                        principalTable: "productionOrdersStatus",
                        principalColumn: "Oid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productionOrders_employees_supervisorOid",
                        column: x => x.supervisorOid,
                        principalTable: "employees",
                        principalColumn: "Oid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_role_UsersOid",
                table: "role",
                column: "UsersOid");

            migrationBuilder.CreateIndex(
                name: "IX_productionOrders_customerOid",
                table: "productionOrders",
                column: "customerOid");

            migrationBuilder.CreateIndex(
                name: "IX_productionOrders_productionStatusOid",
                table: "productionOrders",
                column: "productionStatusOid");

            migrationBuilder.CreateIndex(
                name: "IX_productionOrders_supervisorOid",
                table: "productionOrders",
                column: "supervisorOid");

            migrationBuilder.AddForeignKey(
                name: "FK_role_users_UsersOid",
                table: "role",
                column: "UsersOid",
                principalTable: "users",
                principalColumn: "Oid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_role_users_UsersOid",
                table: "role");

            migrationBuilder.DropTable(
                name: "productionOrders");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "productionOrdersStatus");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropIndex(
                name: "IX_role_UsersOid",
                table: "role");

            migrationBuilder.DropColumn(
                name: "UsersOid",
                table: "role");
        }
    }
}
