using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuleEmployees.Migrations
{
    public partial class fix4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSchedule_Schedules_ScheduleId",
                table: "EmployeeSchedule");

            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "EmployeeSchedule",
                newName: "SchedulesScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSchedule_ScheduleId",
                table: "EmployeeSchedule",
                newName: "IX_EmployeeSchedule_SchedulesScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSchedule_Schedules_SchedulesScheduleId",
                table: "EmployeeSchedule",
                column: "SchedulesScheduleId",
                principalTable: "Schedules",
                principalColumn: "ScheduleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSchedule_Schedules_SchedulesScheduleId",
                table: "EmployeeSchedule");

            migrationBuilder.RenameColumn(
                name: "SchedulesScheduleId",
                table: "EmployeeSchedule",
                newName: "ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSchedule_SchedulesScheduleId",
                table: "EmployeeSchedule",
                newName: "IX_EmployeeSchedule_ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSchedule_Schedules_ScheduleId",
                table: "EmployeeSchedule",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "ScheduleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
