using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanies2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1703471c-c637-489a-b28c-1eeab59f3484");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9726c945-8abf-4d00-aa55-4d98a9dadf1a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d1f91a30-c72d-4f0f-9c17-ecf9045f6a01");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1703471c-c637-489a-b28c-1eeab59f3484", null, "User", "USER" },
                    { "9726c945-8abf-4d00-aa55-4d98a9dadf1a", null, "Client", "CLIENT" },
                    { "d1f91a30-c72d-4f0f-9c17-ecf9045f6a01", null, "Admin", "ADMIN" }
                });
        }
    }
}
