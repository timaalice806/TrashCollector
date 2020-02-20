using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class FixDropdownMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19f5ccc9-6954-4af8-96da-97a8b95d9f1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53004bc6-8573-4061-a73e-efe9e9e675ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61537691-b08d-475f-892b-a2bdadca4303");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "61537691-b08d-475f-892b-a2bdadca4303", "c47dfd48-7869-4622-85dd-2b764486cf90", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19f5ccc9-6954-4af8-96da-97a8b95d9f1f", "ecd70489-6e00-4416-9ec4-cd4d30604f37", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53004bc6-8573-4061-a73e-efe9e9e675ee", "c88bec44-876e-4191-ac3a-03dc8b6011a9", "Employee", "EMPLOYEE" });
        }
    }
}
