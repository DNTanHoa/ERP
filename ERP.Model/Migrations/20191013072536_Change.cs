using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Model.Migrations
{
    public partial class Change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OptimisticLockField",
                table: "users",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OptimisticLockField",
                table: "role",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OptimisticLockField",
                table: "users",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OptimisticLockField",
                table: "role",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
