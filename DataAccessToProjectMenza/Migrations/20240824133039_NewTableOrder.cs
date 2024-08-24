using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessToProjectMenza.Migrations
{
    /// <inheritdoc />
    public partial class NewTableOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Order_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObrokId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Order_Id);
                    table.ForeignKey(
                        name: "FK_Order_Obroci_ObrokId",
                        column: x => x.ObrokId,
                        principalTable: "Obroci",
                        principalColumn: "Obrok_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Persons_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_ObrokId",
                table: "Order",
                column: "ObrokId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StudentId",
                table: "Order",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
