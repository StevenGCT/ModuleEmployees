using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuleEmployees.Migrations
{
    public partial class AddEmployeesExtra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PresenceExtraId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PresenceExtra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAttenddance = table.Column<int>(type: "int", nullable: false),
                    StatusAttendance = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresenceExtra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PresenceExtra_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PresenceExtraId",
                table: "Employees",
                column: "PresenceExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_PresenceExtra_EventId",
                table: "PresenceExtra",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PresenceExtra_PresenceExtraId",
                table: "Employees",
                column: "PresenceExtraId",
                principalTable: "PresenceExtra",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PresenceExtra_PresenceExtraId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "PresenceExtra");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PresenceExtraId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PresenceExtraId",
                table: "Employees");
        }
    }
}
