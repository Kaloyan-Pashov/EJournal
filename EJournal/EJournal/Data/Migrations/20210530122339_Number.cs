using Microsoft.EntityFrameworkCore.Migrations;

namespace EJournal.Data.Migrations
{
    public partial class Number : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2152f72a-644b-4d98-9531-2ef23d061d7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bbed1d6-404d-4d19-9686-45db40f26240");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "386e1913-ade1-4757-ba9d-18f02501fbc4", "53028c6d-5054-4caa-868a-812f6ee87b1b", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4850a4d5-47a3-403a-a72d-cf431567bcec", "bad8c672-2b9c-4f54-92ad-b02e253fe449", "Student", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "386e1913-ade1-4757-ba9d-18f02501fbc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4850a4d5-47a3-403a-a72d-cf431567bcec");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Students");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2152f72a-644b-4d98-9531-2ef23d061d7e", "edd75b40-c76b-457c-856b-a3542daacab8", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2bbed1d6-404d-4d19-9686-45db40f26240", "fb74d5b1-6828-4b7f-9e81-e3039fbcd154", "Student", "STUDENT" });
        }
    }
}
