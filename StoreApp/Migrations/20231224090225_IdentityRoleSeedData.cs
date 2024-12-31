using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApp.Migrations
{
    /// <inheritdoc />
    public partial class IdentityRoleSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1f21f4c-1dba-43bd-948a-d5cb758d51b0", null, "Editor", "EDITOR" },
                    { "ac35b20f-184b-44a0-97b1-c95792124a9e", null, "Admin", "ADMIN" },
                    { "fb20a2b1-9c7e-4efc-8b6d-b0efc62f2d97", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1f21f4c-1dba-43bd-948a-d5cb758d51b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac35b20f-184b-44a0-97b1-c95792124a9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb20a2b1-9c7e-4efc-8b6d-b0efc62f2d97");
        }
    }
}
