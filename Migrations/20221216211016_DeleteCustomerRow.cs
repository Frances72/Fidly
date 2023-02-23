using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fidly.Migrations
{
    /// <inheritdoc />
    public partial class DeleteCustomerRow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "IsSubscribedToNewsletter", "MembershipTypeId", "Name" },
                values: new object[] { 1, true, (byte)2, "Jane Mason" });

        }
    }
}
