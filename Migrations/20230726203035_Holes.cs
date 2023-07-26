using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScoreCardPlus.Migrations
{
    /// <inheritdoc />
    public partial class Holes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoleNumber",
                table: "ScoreCards");

            migrationBuilder.CreateTable(
                name: "Holes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    HoleNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Yardage = table.Column<int>(type: "INTEGER", nullable: false),
                    ParScore = table.Column<int>(type: "INTEGER", nullable: false),
                    ScoreCardID = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holes_ScoreCards_ScoreCardID",
                        column: x => x.ScoreCardID,
                        principalTable: "ScoreCards",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Holes_ScoreCardID",
                table: "Holes",
                column: "ScoreCardID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Holes");

            migrationBuilder.AddColumn<int>(
                name: "HoleNumber",
                table: "ScoreCards",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
