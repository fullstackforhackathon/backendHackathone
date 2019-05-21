using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backendHackathone.DAL.Migrations
{
    public partial class InitialMigration629 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessEntityTypeFields",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessEntityTypeId = table.Column<int>(nullable: false),
                    FieldId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessEntityTypeFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessEntityTypeFields_BusinessEntityTypes_BusinessEntityTypeId",
                        column: x => x.BusinessEntityTypeId,
                        principalTable: "BusinessEntityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessEntityTypeFields_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntityTypeFields_BusinessEntityTypeId",
                table: "BusinessEntityTypeFields",
                column: "BusinessEntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntityTypeFields_FieldId",
                table: "BusinessEntityTypeFields",
                column: "FieldId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessEntityTypeFields");
        }
    }
}
