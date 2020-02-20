using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class HomeCustomerView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08fddeee-233e-4c03-866d-68aa10bfb413");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1098f9fd-9659-4ab1-af08-f1d9325cd917");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95befe08-f2d1-485e-86b2-098b46a8b934");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "95befe08-f2d1-485e-86b2-098b46a8b934", "dd16e78b-4122-4f2b-9aeb-35f89234a6f5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08fddeee-233e-4c03-866d-68aa10bfb413", "398610be-4cb0-4687-aa46-7d0d93742eae", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1098f9fd-9659-4ab1-af08-f1d9325cd917", "0dd8b4f3-b4d2-48ba-9891-22142a5a94a5", "Employee", "EMPLOYEE" });
        }
    }
}
