using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fidly.Migrations
{
    /// <inheritdoc />
    public partial class MovieData100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO dbo.Genre (Id, GenreName) VALUES (1, 'Action')");
migrationBuilder.Sql(@"INSERT INTO dbo.Genre (Id,GenreName) VALUES (2,'Documentary')");
migrationBuilder.Sql(@"INSERT INTO dbo.Genre (Id,GenreName) VALUES (3, 'Comedy')");
migrationBuilder.Sql(@"INSERT INTO dbo.Genre (Id,GenreName) VALUES (4, 'Drama')");
migrationBuilder.Sql(@"INSERT INTO dbo.Genre (Id,GenreName) VALUES (5, 'RomCom')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
