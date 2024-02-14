using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Bronson.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    FormID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieCategory = table.Column<string>(type: "TEXT", nullable: false),
                    MovieTitle = table.Column<string>(type: "TEXT", nullable: false),
                    MovieYear = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    MovieDirector = table.Column<string>(type: "TEXT", nullable: false),
                    MovieRating = table.Column<string>(type: "TEXT", nullable: false),
                    MovieEdited = table.Column<bool>(type: "INTEGER", nullable: false),
                    MovieLent = table.Column<string>(type: "TEXT", nullable: false),
                    MovieNotes = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.FormID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");
        }
    }
}
