using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScoreCardPlus.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScoreCards",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Course = table.Column<string>(type: "TEXT", nullable: true),
                    NumberofHoles = table.Column<int>(type: "INTEGER", nullable: false),
                    ParCourseTotal = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberofPlayers = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreCards", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScoreCards");
        }
    }
}
