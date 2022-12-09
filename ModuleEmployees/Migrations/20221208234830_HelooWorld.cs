using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuleEmployees.Migrations
{
    public partial class HelooWorld : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePresenceWork");

            migrationBuilder.CreateIndex(
                name: "IX_PresenceWorks_EmployeeId",
                table: "PresenceWorks",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PresenceWorks_Employees_EmployeeId",
                table: "PresenceWorks",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PresenceWorks_Employees_EmployeeId",
                table: "PresenceWorks");

            migrationBuilder.DropIndex(
                name: "IX_PresenceWorks_EmployeeId",
                table: "PresenceWorks");

            migrationBuilder.CreateTable(
                name: "EmployeePresenceWork",
                columns: table => new
                {
                    PresenceWorksId = table.Column<int>(type: "int", nullable: false),
                    employeesEmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePresenceWork", x => new { x.PresenceWorksId, x.employeesEmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeePresenceWork_Employees_employeesEmployeeId",
                        column: x => x.employeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeePresenceWork_PresenceWorks_PresenceWorksId",
                        column: x => x.PresenceWorksId,
                        principalTable: "PresenceWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePresenceWork_employeesEmployeeId",
                table: "EmployeePresenceWork",
                column: "employeesEmployeeId");
        }
    }
}
