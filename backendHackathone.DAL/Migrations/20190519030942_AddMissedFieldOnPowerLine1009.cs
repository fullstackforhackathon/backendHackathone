using Microsoft.EntityFrameworkCore.Migrations;

namespace backendHackathone.DAL.Migrations
{
    public partial class AddMissedFieldOnPowerLine1009 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubmissionScopeId",
                table: "PowerLinesData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PowerLinesData_SubmissionScopeId",
                table: "PowerLinesData",
                column: "SubmissionScopeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PowerLinesData_SubmissionScopes_SubmissionScopeId",
                table: "PowerLinesData",
                column: "SubmissionScopeId",
                principalTable: "SubmissionScopes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PowerLinesData_SubmissionScopes_SubmissionScopeId",
                table: "PowerLinesData");

            migrationBuilder.DropIndex(
                name: "IX_PowerLinesData_SubmissionScopeId",
                table: "PowerLinesData");

            migrationBuilder.DropColumn(
                name: "SubmissionScopeId",
                table: "PowerLinesData");
        }
    }
}
