using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fidly.Migrations
{
    /// <inheritdoc />
    public partial class JustGenreIdWithoutGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "GenreId",
                table: "Movie",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Movie");
        }
    }
}
