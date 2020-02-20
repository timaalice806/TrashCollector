using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class SeededIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "185d1a38-de0c-4e85-b0cd-671519ae0819");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "185d1a38-de0c-4e85-b0cd-671519ae0819", "06ae4f55-9b99-4b88-bc86-aa808a00a001", "Admin", "ADMIN" });
        }
    }
}
