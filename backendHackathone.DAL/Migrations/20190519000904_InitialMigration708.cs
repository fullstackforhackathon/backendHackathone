using Microsoft.EntityFrameworkCore.Migrations;

namespace backendHackathone.DAL.Migrations
{
    public partial class InitialMigration708 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PowerLineId",
                table: "FieldValues",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FieldValues_PowerLineId",
                table: "FieldValues",
                column: "PowerLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_FieldValues_PowerLinesData_PowerLineId",
                table: "FieldValues",
                column: "PowerLineId",
                principalTable: "PowerLinesData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FieldValues_PowerLinesData_PowerLineId",
                table: "FieldValues");

            migrationBuilder.DropIndex(
                name: "IX_FieldValues_PowerLineId",
                table: "FieldValues");

            migrationBuilder.DropColumn(
                name: "PowerLineId",
                table: "FieldValues");
        }
    }
}
