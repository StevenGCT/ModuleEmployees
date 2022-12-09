using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuleEmployees.Migrations
{
    public partial class PresenceWorks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PresenceWork",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAttenddance = table.Column<int>(type: "int", nullable: false),
                    StatusAttendance = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresenceWork", x => x.Id);
                });

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
                        name: "FK_EmployeePresenceWork_PresenceWork_PresenceWorksId",
                        column: x => x.PresenceWorksId,
                        principalTable: "PresenceWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePresenceWork_employeesEmployeeId",
                table: "EmployeePresenceWork",
                column: "employeesEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePresenceWork");

            migrationBuilder.DropTable(
                name: "PresenceWork");
        }
    }
}
