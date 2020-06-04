using Microsoft.EntityFrameworkCore.Migrations;

namespace eComApi.Migrations
{
    public partial class seeddataadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Active Wear - Men" },
                    { 2, "Active Wear - Women" },
                    { 3, "Mineral Water" },
                    { 4, "Publications" },
                    { 5, "Supplements" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email" },
                values: new object[,]
                {
                    { 1, "adam@example.com" },
                    { 2, "barbara@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "IsAvailable", "Name", "OrderId", "Price", "Sku" },
                values: new object[,]
                {
                    { 1, 1, null, true, "Grunge Skater Jeans", null, 68m, "AWMGSJ" },
                    { 31, 5, null, true, "Vitamin B-Complex (100 caplets)", null, 12.99m, "SVB" },
                    { 30, 5, null, true, "Vitamin A 10,000 IU (125 caplets)", null, 11.99m, "SVA" },
                    { 29, 5, null, true, "Multi-Vitamin (90 capsules)", null, 9.99m, "SMV" },
                    { 28, 5, null, true, "Magnesium 250 mg (100 tablets)", null, 12.49m, "SM250" },
                    { 27, 5, null, true, "Iron 65 mg (150 caplets)", null, 13.99m, "SI65" },
                    { 26, 5, null, true, "Flaxseed Oil 100 mg (90 capsules)", null, 12.49m, "SFO100" },
                    { 25, 5, null, true, "Calcium 400 IU (150 tablets)", null, 9.99m, "SC400" },
                    { 24, 4, null, true, "In the Kitchen with H+ Sport", null, 24.99m, "PITK" },
                    { 23, 3, null, true, "Strawberry Mineral Water", null, 2.8m, "MWS" },
                    { 22, 3, null, true, "Raspberry Mineral Water", null, 2.8m, "MWR" },
                    { 21, 3, null, true, "Peach Mineral Water", null, 2.8m, "MWP" },
                    { 20, 3, null, true, "Orange Mineral Water", null, 2.8m, "MWO" },
                    { 19, 3, null, true, "Lemon-Lime Mineral Water", null, 2.8m, "MWLL" },
                    { 18, 3, null, true, "Blueberry Mineral Water", null, 2.8m, "MWB" },
                    { 32, 5, null, true, "Vitamin C 1000 mg (100 tablets)", null, 9.99m, "SVC" },
                    { 17, 2, null, true, "V-Next T-Shirt", null, 17m, "AWWVNT" },
                    { 15, 2, null, true, "Ultra-Soft Tank Top", null, 22m, "AWWUTT" },
                    { 14, 2, null, true, "Stretchy Dance Pants", null, 55m, "AWWSDP" },
                    { 13, 2, null, true, "Slicker Jacket", null, 125m, "AWWSJ" },
                    { 12, 2, null, true, "Grunge Skater Jeans", null, 68m, "AWWGSJ" },
                    { 11, 2, null, false, "Cross-Back Training Tank", null, 0m, "AWWCTT" },
                    { 10, 2, null, true, "Bamboo Thermal Ski Coat", null, 99m, "AWWBTSC" },
                    { 9, 1, null, true, "V-Neck T-Shirt", null, 17m, "AWMVNT" },
                    { 8, 1, null, true, "V-Neck Sweater", null, 65m, "AWMVNS" },
                    { 7, 1, null, true, "V-Neck Pullover", null, 65m, "AWMVNP" },
                    { 6, 1, null, true, "Unisex Thermal Vest", null, 95m, "AWMUTV" },
                    { 5, 1, null, true, "Thermal Fleece Jacket", null, 60m, "AWMTFJ" },
                    { 4, 1, null, true, "Slicker Jacket", null, 125m, "AWMSJ" },
                    { 3, 1, null, true, "Skater Graphic T-Shirt", null, 33m, "AWMSGT" },
                    { 2, 1, null, true, "Polo Shirt", null, 35m, "AWMPS" },
                    { 16, 2, null, true, "Unisex Thermal Vest", null, 95m, "AWWUTV" },
                    { 33, 5, null, true, "Vitamin D3 1000 IU (100 tablets)", null, 12.49m, "SVD3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
