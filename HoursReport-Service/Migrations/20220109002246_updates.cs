using Microsoft.EntityFrameworkCore.Migrations;

namespace HoursReport_Service.Migrations
{
    public partial class updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_Project_ProjectsProjectId",
                table: "ProjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_User_UsersUserId",
                table: "ProjectUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectUser",
                table: "ProjectUser");

            migrationBuilder.RenameColumn(
                name: "UsersUserId",
                table: "ProjectUser",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ProjectsProjectId",
                table: "ProjectUser",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectUser_UsersUserId",
                table: "ProjectUser",
                newName: "IX_ProjectUser_UserId");

            migrationBuilder.AddColumn<int>(
                name: "ProjectUserId",
                table: "ProjectUser",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectUser",
                table: "ProjectUser",
                column: "ProjectUserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ProjectId",
                table: "ProjectUser",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_Project_ProjectId",
                table: "ProjectUser",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_User_UserId",
                table: "ProjectUser",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_Project_ProjectId",
                table: "ProjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUser_User_UserId",
                table: "ProjectUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectUser",
                table: "ProjectUser");

            migrationBuilder.DropIndex(
                name: "IX_ProjectUser_ProjectId",
                table: "ProjectUser");

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumn: "ProjectUserId",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumn: "ProjectUserId",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumn: "ProjectUserId",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumn: "ProjectUserId",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProjectUser",
                keyColumn: "ProjectUserId",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ProjectUserId",
                table: "ProjectUser");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ProjectUser",
                newName: "UsersUserId");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "ProjectUser",
                newName: "ProjectsProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectUser_UserId",
                table: "ProjectUser",
                newName: "IX_ProjectUser_UsersUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectUser",
                table: "ProjectUser",
                columns: new[] { "ProjectsProjectId", "UsersUserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_Project_ProjectsProjectId",
                table: "ProjectUser",
                column: "ProjectsProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUser_User_UsersUserId",
                table: "ProjectUser",
                column: "UsersUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
