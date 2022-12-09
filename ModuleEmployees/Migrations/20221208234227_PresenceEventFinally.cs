using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuleEmployees.Migrations
{
    public partial class PresenceEventFinally : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePresenceWork_PresenceWork_PresenceWorksId",
                table: "EmployeePresenceWork");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PresenceWork",
                table: "PresenceWork");

            migrationBuilder.RenameTable(
                name: "PresenceWork",
                newName: "PresenceWorks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PresenceWorks",
                table: "PresenceWorks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePresenceWork_PresenceWorks_PresenceWorksId",
                table: "EmployeePresenceWork",
                column: "PresenceWorksId",
                principalTable: "PresenceWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePresenceWork_PresenceWorks_PresenceWorksId",
                table: "EmployeePresenceWork");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PresenceWorks",
                table: "PresenceWorks");

            migrationBuilder.RenameTable(
                name: "PresenceWorks",
                newName: "PresenceWork");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PresenceWork",
                table: "PresenceWork",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePresenceWork_PresenceWork_PresenceWorksId",
                table: "EmployeePresenceWork",
                column: "PresenceWorksId",
                principalTable: "PresenceWork",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
