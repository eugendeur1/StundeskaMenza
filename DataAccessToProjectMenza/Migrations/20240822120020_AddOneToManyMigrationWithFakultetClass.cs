using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessToProjectMenza.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToManyMigrationWithFakultetClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fakultet_Id",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fakultets",
                columns: table => new
                {
                    Fakultet_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakultets", x => x.Fakultet_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Fakultet_Id",
                table: "Persons",
                column: "Fakultet_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Fakultets_Fakultet_Id",
                table: "Persons",
                column: "Fakultet_Id",
                principalTable: "Fakultets",
                principalColumn: "Fakultet_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Fakultets_Fakultet_Id",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Fakultets");

            migrationBuilder.DropIndex(
                name: "IX_Persons_Fakultet_Id",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Fakultet_Id",
                table: "Persons");
        }
    }
}
