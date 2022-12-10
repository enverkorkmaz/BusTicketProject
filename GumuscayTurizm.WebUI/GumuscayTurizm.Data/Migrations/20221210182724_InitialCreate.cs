using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GumuscayTurizm.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstimatedTime",
                table: "Trips",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 1,
                column: "EstimatedTime",
                value: "4sa45dk");

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 2,
                column: "EstimatedTime",
                value: "1sa45dk");

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 3,
                column: "EstimatedTime",
                value: "4sa45dk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstimatedTime",
                table: "Trips");
        }
    }
}
