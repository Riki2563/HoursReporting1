using Microsoft.EntityFrameworkCore.Migrations;

namespace HoursReport_Service.Migrations
{
    public partial class fillData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "ProjectName" },
                values: new object[,]
                {
                    { 10, "Biosense" },
                    { 20, "KsharimPlus" },
                    { 30, "Inetap" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Password", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "YosefC1122@gmail.com", "Yos1122", 1, "יוסף כהן" },
                    { 2, "ShimL8877@gmail.com", "Shim8877", 2, "שמעון לוי" },
                    { 3, "ShoshM8989@gmail.com", "Shosh8989", 2, "שושנה מחפוד" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3);
        }
    }
}
