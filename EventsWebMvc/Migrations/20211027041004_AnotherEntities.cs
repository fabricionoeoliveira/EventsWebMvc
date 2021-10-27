using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsWebMvc.Migrations
{
    public partial class AnotherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventsRecords_User_UserId",
                table: "EventsRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventsRecords",
                table: "EventsRecords");

            migrationBuilder.RenameTable(
                name: "EventsRecords",
                newName: "EventsRecord");

            migrationBuilder.RenameIndex(
                name: "IX_EventsRecords_UserId",
                table: "EventsRecord",
                newName: "IX_EventsRecord_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventsRecord",
                table: "EventsRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventsRecord_User_UserId",
                table: "EventsRecord",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventsRecord_User_UserId",
                table: "EventsRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventsRecord",
                table: "EventsRecord");

            migrationBuilder.RenameTable(
                name: "EventsRecord",
                newName: "EventsRecords");

            migrationBuilder.RenameIndex(
                name: "IX_EventsRecord_UserId",
                table: "EventsRecords",
                newName: "IX_EventsRecords_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventsRecords",
                table: "EventsRecords",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventsRecords_User_UserId",
                table: "EventsRecords",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
