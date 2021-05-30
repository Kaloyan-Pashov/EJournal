using Microsoft.EntityFrameworkCore.Migrations;

namespace EJournal.Data.Migrations
{
    public partial class registerchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08326fb7-78b9-4bb4-81b2-bbfb8d36d6cb", "0008ef47-566b-4190-8544-9fd0bad08476", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "309d309f-025a-44be-836c-12736bd46c65", "b33601d3-0273-4671-b88c-0c26243a4003", "Student", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08326fb7-78b9-4bb4-81b2-bbfb8d36d6cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "309d309f-025a-44be-836c-12736bd46c65");
        }
    }
}
