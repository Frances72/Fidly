using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fidly.Migrations
{
    /// <inheritdoc />
    public partial class AddMovieData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO dbo.Movie (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Top Gun Maverick', 1, '2022-05-16', '2022-12-20', 5)");
migrationBuilder.Sql(@"INSERT INTO dbo.Movie (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Absolute Truth', 2, '2015-01-16', '2022-12-20', 1)");
migrationBuilder.Sql(@"INSERT INTO dbo.Movie (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Vaxxed', 2, '2019-07-12', '2022-12-20',2)");
migrationBuilder.Sql(@"INSERT INTO dbo.Movie (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Plandemic', 3, '2020-04-16', '2022-12-20', 3)");
migrationBuilder.Sql(@"INSERT INTO dbo.Movie (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Patch Adams', 5, '1999-05-16', '2022-12-20', 1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
