using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class FixDropdown2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80011420-3c2c-4cb1-9fd7-00331ffbe937");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf0acc4f-6a78-4caf-9bf9-cdcdf85e5b59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f92dea62-97b5-4ab9-be71-0a641b4fd335");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5769486-7c9f-4a14-8c25-91d09c2a9c16", "22f3582e-054c-429b-9cf2-0b21eec012b8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c141e74-9b74-4ec7-ba0f-c1e3e47d09c4", "4a1d2ccf-adee-4e90-b095-d230060f2f82", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70d29930-42c5-47a9-8c08-c57fae6a598a", "3c2bb437-8683-45a6-9341-2050fe37db92", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c141e74-9b74-4ec7-ba0f-c1e3e47d09c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70d29930-42c5-47a9-8c08-c57fae6a598a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5769486-7c9f-4a14-8c25-91d09c2a9c16");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80011420-3c2c-4cb1-9fd7-00331ffbe937", "407b1b3a-c3fc-4024-9fd2-50aadea61d93", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f92dea62-97b5-4ab9-be71-0a641b4fd335", "607ad66b-37e5-4c1d-93b9-60c3ba5125fb", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf0acc4f-6a78-4caf-9bf9-cdcdf85e5b59", "d617dd73-2f7b-401a-85cb-cf47cc68ee69", "Employee", "EMPLOYEE" });
        }
    }
}
