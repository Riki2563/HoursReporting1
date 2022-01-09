using Microsoft.EntityFrameworkCore.Migrations;

namespace HoursReport_Service.Migrations
{
    public partial class updates6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProjectUser",
                columns: new[] { "ProjectUserId", "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 1, 10, 1 },
                    { 2, 20, 1 },
                    { 3, 30, 1 },
                    { 4, 20, 2 },
                    { 5, 30, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumn: "ProjectUserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumn: "ProjectUserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumn: "ProjectUserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumn: "ProjectUserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumn: "ProjectUserId",
                keyValue: 5);
        }
    }
}
