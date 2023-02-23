using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fidly.Migrations
{
    /// <inheritdoc />
    public partial class updateMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO dbo.Genre (GenreName) VALUES ('Action')");
            migrationBuilder.Sql(@"INSERT INTO dbo.Genre (GenreName) VALUES ('Documentary')");
            migrationBuilder.Sql(@"INSERT INTO dbo.Genre (GenreName) VALUES ('Comedy')");
            migrationBuilder.Sql(@"INSERT INTO dbo.Genre (GenreName) VALUES ('Drama')");
            migrationBuilder.Sql(@"INSERT INTO dbo.Genre (GenreName) VALUES ('RomCom')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
