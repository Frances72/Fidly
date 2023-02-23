using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fidly.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataCustomer5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "IsSubscribedToNewsletter", "MembershipTypeId", "Name" },
                values: new object[,]
                {
                    { 1, true, (byte)3, "Jane Ruby" },
                    { 2, true, (byte)2, "Peter Pan" },
                    { 3, false, (byte)1, "Stew Peters" },
                    { 4, true, (byte)3, "Mark Snow" },
                    { 5, true, (byte)1, "Allen Key" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
