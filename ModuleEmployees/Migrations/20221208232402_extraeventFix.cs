using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuleEmployees.Migrations
{
    public partial class extraeventFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePresenceExtra");

            migrationBuilder.DropTable(
                name: "PresenceExtra");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PresenceExtra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAttenddance = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StatusAttendance = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresenceExtra", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePresenceExtra",
                columns: table => new
                {
                    PresenceExtrasId = table.Column<int>(type: "int", nullable: false),
                    employeesEmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePresenceExtra", x => new { x.PresenceExtrasId, x.employeesEmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeePresenceExtra_Employees_employeesEmployeeId",
                        column: x => x.employeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeePresenceExtra_PresenceExtra_PresenceExtrasId",
                        column: x => x.PresenceExtrasId,
                        principalTable: "PresenceExtra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePresenceExtra_employeesEmployeeId",
                table: "EmployeePresenceExtra",
                column: "employeesEmployeeId");
        }
    }
}
