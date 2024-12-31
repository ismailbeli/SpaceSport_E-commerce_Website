using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApp.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3738fea5-dc1d-48d6-8c4a-46d270425311", null, "Editor", "EDITOR" },
                    { "a4bcbaf7-6cbf-4dd6-9811-d91e2613c12f", null, "Admin", "ADMIN" },
                    { "e845e76d-4a33-4dea-86cc-6a1555a06d6d", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Outfit");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/31.jpg", 5000m, "Nike Kadın Forma" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/32.jpg", 3000m, "Türkiye Voleybol Forma" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/33.jpg", 4500m, "Adidas Forma" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/34.jpg", 5500m, "Basketbol Forması Erkek" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/35.jpg", 4499m, "Adidas Eşofman Altı Kadın" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/26.jpg", 43503m, "Nike Air Max Ltd 3 Siyah" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/27.jpg", 2275m, "Puma Rebound V6 Low Yeşil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/28.jpg", 2925m, "Puma Rebound V6 Low Kırmızı" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CategoryId", "ImageUrl", "Price", "ProductName" },
                values: new object[] { 1, "/images/29.jpg", 4950m, "Nike Court Vision Mid Wntr Sarı" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/30.jpg", 5499m, "Skechers D'Lux Walker Gri" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ImageUrl", "Price", "ProductName", "ShowCase", "Summary" },
                values: new object[,]
                {
                    { 11, 2, "/images/36.jpg", 2000m, "Eşofman Altı Turuncu Kadın", false, "" },
                    { 12, 2, "/images/37.jpg", 3500m, "Nike Mavi Eşofman Erkek", true, "" },
                    { 13, 2, "/images/38.jpg", 3200m, "Puma Bej Eşofman", false, "" },
                    { 14, 2, "/images/39.jpg", 1500m, "Puma T-shirt Siyah Kadın", true, "" },
                    { 15, 2, "/images/40.jpg", 1950m, "Puma T-shirt Kadın", false, "" },
                    { 16, 2, "/images/41.jpg", 2250m, "North Face Yeşil Erkek", true, "" },
                    { 17, 2, "/images/42.jpg", 2500m, "Nike Gri T-shirt Erkek", false, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3738fea5-dc1d-48d6-8c4a-46d270425311");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4bcbaf7-6cbf-4dd6-9811-d91e2613c12f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e845e76d-4a33-4dea-86cc-6a1555a06d6d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1f21f4c-1dba-43bd-948a-d5cb758d51b0", null, "Editor", "EDITOR" },
                    { "ac35b20f-184b-44a0-97b1-c95792124a9e", null, "Admin", "ADMIN" },
                    { "fb20a2b1-9c7e-4efc-8b6d-b0efc62f2d97", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Book");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Electronic");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/1.jpg", 17000m, "Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/2.jpg", 1000m, "Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/3.jpg", 500m, "Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/4.jpg", 7000m, "Monitor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/5.jpg", 1500m, "Deck" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/6.jpg", 25m, "History" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/7.jpg", 45m, "Hamlet" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/8.jpg", 1145m, "Xp-Pen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CategoryId", "ImageUrl", "Price", "ProductName" },
                values: new object[] { 2, "/images/9.jpg", 4445m, "Galaxy FE" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "ImageUrl", "Price", "ProductName" },
                values: new object[] { "/images/10.jpg", 545m, "Hp Mouse" });
        }
    }
}
