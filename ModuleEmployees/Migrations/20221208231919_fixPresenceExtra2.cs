using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuleEmployees.Migrations
{
    public partial class fixPresenceExtra2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePresenceExtra_Employees_EmployeesEmployeeId",
                table: "EmployeePresenceExtra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeePresenceExtra",
                table: "EmployeePresenceExtra");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePresenceExtra_PresenceExtrasId",
                table: "EmployeePresenceExtra");

            migrationBuilder.RenameColumn(
                name: "EmployeesEmployeeId",
                table: "EmployeePresenceExtra",
                newName: "employeesEmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeePresenceExtra",
                table: "EmployeePresenceExtra",
                columns: new[] { "PresenceExtrasId", "employeesEmployeeId" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePresenceExtra_employeesEmployeeId",
                table: "EmployeePresenceExtra",
                column: "employeesEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePresenceExtra_Employees_employeesEmployeeId",
                table: "EmployeePresenceExtra",
                column: "employeesEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePresenceExtra_Employees_employeesEmployeeId",
                table: "EmployeePresenceExtra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeePresenceExtra",
                table: "EmployeePresenceExtra");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePresenceExtra_employeesEmployeeId",
                table: "EmployeePresenceExtra");

            migrationBuilder.RenameColumn(
                name: "employeesEmployeeId",
                table: "EmployeePresenceExtra",
                newName: "EmployeesEmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeePresenceExtra",
                table: "EmployeePresenceExtra",
                columns: new[] { "EmployeesEmployeeId", "PresenceExtrasId" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePresenceExtra_PresenceExtrasId",
                table: "EmployeePresenceExtra",
                column: "PresenceExtrasId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePresenceExtra_Employees_EmployeesEmployeeId",
                table: "EmployeePresenceExtra",
                column: "EmployeesEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
