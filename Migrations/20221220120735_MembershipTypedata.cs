using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fidly.Migrations
{
    /// <inheritdoc />
    public partial class MembershipTypedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"UPDATE dbo.MembershipType SET MembershipName = 'None' WHERE Id = 1");
            migrationBuilder.Sql(@"UPDATE dbo.MembershipType SET MembershipName = 'Monthly' WHERE Id = 2");
            migrationBuilder.Sql(@"UPDATE dbo.MembershipType SET MembershipName = 'Quaterly' WHERE Id = 3");
            migrationBuilder.Sql(@"UPDATE dbo.MembershipType SET MembershipName = 'Annual' WHERE Id = 4");  

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
