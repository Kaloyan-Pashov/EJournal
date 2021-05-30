using Microsoft.EntityFrameworkCore.Migrations;

namespace EJournal.Data.Migrations
{
    public partial class usernum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "386e1913-ade1-4757-ba9d-18f02501fbc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4850a4d5-47a3-403a-a72d-cf431567bcec");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e65e5ea1-a3ec-4b74-bf46-d3fa9787f1ed", "5e988c05-2143-4911-a553-a562d2a683f6", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58d08faf-4b2b-40bc-bae2-a7876f4c488d", "e158f834-f3c8-4b5f-b447-bc31a59d0c4a", "Student", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58d08faf-4b2b-40bc-bae2-a7876f4c488d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65e5ea1-a3ec-4b74-bf46-d3fa9787f1ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "386e1913-ade1-4757-ba9d-18f02501fbc4", "53028c6d-5054-4caa-868a-812f6ee87b1b", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4850a4d5-47a3-403a-a72d-cf431567bcec", "bad8c672-2b9c-4f54-92ad-b02e253fe449", "Student", "STUDENT" });
        }
    }
}
