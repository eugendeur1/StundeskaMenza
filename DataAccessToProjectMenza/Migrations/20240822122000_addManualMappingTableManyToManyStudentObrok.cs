using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessToProjectMenza.Migrations
{
    /// <inheritdoc />
    public partial class addManualMappingTableManyToManyStudentObrok : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Obroci",
                columns: table => new
                {
                    Obrok_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Obrok_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obroci", x => x.Obrok_Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentObroci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ObrokId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentObroci", x => new { x.Id, x.ObrokId });
                    table.ForeignKey(
                        name: "FK_StudentObroci_Obroci_ObrokId",
                        column: x => x.ObrokId,
                        principalTable: "Obroci",
                        principalColumn: "Obrok_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentObroci_Persons_Id",
                        column: x => x.Id,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentObroci_ObrokId",
                table: "StudentObroci",
                column: "ObrokId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentObroci");

            migrationBuilder.DropTable(
                name: "Obroci");
        }
    }
}
