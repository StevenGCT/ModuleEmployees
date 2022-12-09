using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuleEmployees.Migrations
{
    public partial class fixPresenceExtra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PresenceExtra_PresenceExtraId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_PresenceExtra_Events_EventId",
                table: "PresenceExtra");

            migrationBuilder.DropIndex(
                name: "IX_PresenceExtra_EventId",
                table: "PresenceExtra");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PresenceExtraId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "PresenceExtra");

            migrationBuilder.DropColumn(
                name: "PresenceExtraId",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "EmployeePresenceExtra",
                columns: table => new
                {
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false),
                    PresenceExtrasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePresenceExtra", x => new { x.EmployeesEmployeeId, x.PresenceExtrasId });
                    table.ForeignKey(
                        name: "FK_EmployeePresenceExtra_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
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
                name: "IX_EmployeePresenceExtra_PresenceExtrasId",
                table: "EmployeePresenceExtra",
                column: "PresenceExtrasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePresenceExtra");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "PresenceExtra",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PresenceExtraId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PresenceExtra_EventId",
                table: "PresenceExtra",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PresenceExtraId",
                table: "Employees",
                column: "PresenceExtraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PresenceExtra_PresenceExtraId",
                table: "Employees",
                column: "PresenceExtraId",
                principalTable: "PresenceExtra",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PresenceExtra_Events_EventId",
                table: "PresenceExtra",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId");
        }
    }
}
