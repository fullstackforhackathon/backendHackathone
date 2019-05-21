using Microsoft.EntityFrameworkCore.Migrations;

namespace backendHackathone.DAL.Migrations
{
    public partial class AddMissedFieldOnFieldValues1059 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FieldsMappingRules_Fields_OriginFieldId",
                table: "FieldsMappingRules");

            migrationBuilder.DropForeignKey(
                name: "FK_FieldsMappingRules_Fields_SourceFieldId",
                table: "FieldsMappingRules");

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "FieldValues",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SourceFieldId",
                table: "FieldsMappingRules",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OriginFieldId",
                table: "FieldsMappingRules",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FieldsMappingRules_ConfigurationId",
                table: "FieldsMappingRules",
                column: "ConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_AgeRanges_ConfigurationId",
                table: "AgeRanges",
                column: "ConfigurationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AgeRanges_Configurations_ConfigurationId",
                table: "AgeRanges",
                column: "ConfigurationId",
                principalTable: "Configurations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FieldsMappingRules_Configurations_ConfigurationId",
                table: "FieldsMappingRules",
                column: "ConfigurationId",
                principalTable: "Configurations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FieldsMappingRules_Fields_OriginFieldId",
                table: "FieldsMappingRules",
                column: "OriginFieldId",
                principalTable: "Fields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FieldsMappingRules_Fields_SourceFieldId",
                table: "FieldsMappingRules",
                column: "SourceFieldId",
                principalTable: "Fields",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgeRanges_Configurations_ConfigurationId",
                table: "AgeRanges");

            migrationBuilder.DropForeignKey(
                name: "FK_FieldsMappingRules_Configurations_ConfigurationId",
                table: "FieldsMappingRules");

            migrationBuilder.DropForeignKey(
                name: "FK_FieldsMappingRules_Fields_OriginFieldId",
                table: "FieldsMappingRules");

            migrationBuilder.DropForeignKey(
                name: "FK_FieldsMappingRules_Fields_SourceFieldId",
                table: "FieldsMappingRules");

            migrationBuilder.DropIndex(
                name: "IX_FieldsMappingRules_ConfigurationId",
                table: "FieldsMappingRules");

            migrationBuilder.DropIndex(
                name: "IX_AgeRanges_ConfigurationId",
                table: "AgeRanges");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "FieldValues");

            migrationBuilder.AlterColumn<int>(
                name: "SourceFieldId",
                table: "FieldsMappingRules",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OriginFieldId",
                table: "FieldsMappingRules",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_FieldsMappingRules_Fields_OriginFieldId",
                table: "FieldsMappingRules",
                column: "OriginFieldId",
                principalTable: "Fields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FieldsMappingRules_Fields_SourceFieldId",
                table: "FieldsMappingRules",
                column: "SourceFieldId",
                principalTable: "Fields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
