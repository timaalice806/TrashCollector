using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class UpdateCustomerViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fa010b0-5125-49e6-94fc-f477fb059408");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "306edf89-b2f5-4f3f-ada9-368bae41052f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de9aed46-5ab6-41bb-be8d-c9e849c18264");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c08ff4e4-3bd0-4d49-b1a6-3db87b929b75", "8d18ca11-1df3-443b-ad33-424f243a97db", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31eea4aa-c7cc-48e3-b246-9cfaf46e8591", "0bc04f18-6da3-4307-9389-844b3cd8554a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c24e6bf6-66d4-4da9-a5d2-be819bb63914", "3084afec-2eac-44b6-a3c9-1c5417a18635", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31eea4aa-c7cc-48e3-b246-9cfaf46e8591");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c08ff4e4-3bd0-4d49-b1a6-3db87b929b75");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c24e6bf6-66d4-4da9-a5d2-be819bb63914");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1fa010b0-5125-49e6-94fc-f477fb059408", "82af94e8-b57c-41f9-8183-ea7bed745577", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "306edf89-b2f5-4f3f-ada9-368bae41052f", "f2ab6429-b4fe-4f85-9385-ab847c4857f5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de9aed46-5ab6-41bb-be8d-c9e849c18264", "3daeac05-e13b-4b7c-a0ed-f80070eb60d0", "Employee", "EMPLOYEE" });
        }
    }
}
