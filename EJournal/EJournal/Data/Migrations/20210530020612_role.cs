using Microsoft.EntityFrameworkCore.Migrations;

namespace EJournal.Data.Migrations
{
    public partial class role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43384554-7300-4119-a78e-2cd1ec585f9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4a735e6-e063-4ed3-8ef4-c391418ef618");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2152f72a-644b-4d98-9531-2ef23d061d7e", "edd75b40-c76b-457c-856b-a3542daacab8", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2bbed1d6-404d-4d19-9686-45db40f26240", "fb74d5b1-6828-4b7f-9e81-e3039fbcd154", "Student", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2152f72a-644b-4d98-9531-2ef23d061d7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bbed1d6-404d-4d19-9686-45db40f26240");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4a735e6-e063-4ed3-8ef4-c391418ef618", "7bed1c4c-46a7-464c-acda-58c50df5de48", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43384554-7300-4119-a78e-2cd1ec585f9a", "74c3e782-3edc-4bed-ba84-8862588e00d3", "Student", "STUDENT" });
        }
    }
}
