using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GumuscayTurizm.Data.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Busses",
                columns: table => new
                {
                    BusId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SeatingCapacity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Busses", x => x.BusId);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassengerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    IdentificationNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassengerId);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FromWhereId = table.Column<int>(type: "INTEGER", nullable: false),
                    ToWhereId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParentRouteId = table.Column<int>(type: "INTEGER", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    RouteId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId");
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(type: "TEXT", nullable: true),
                    Time = table.Column<string>(type: "TEXT", nullable: true),
                    RouteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                    table.ForeignKey(
                        name: "FK_Trips_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PassengerId = table.Column<int>(type: "INTEGER", nullable: false),
                    TripId = table.Column<int>(type: "INTEGER", nullable: false),
                    SeatNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    BusId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Busses_BusId",
                        column: x => x.BusId,
                        principalTable: "Busses",
                        principalColumn: "BusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Passengers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "Passengers",
                        principalColumn: "PassengerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Busses",
                columns: new[] { "BusId", "Name", "SeatingCapacity" },
                values: new object[] { 1, "Mercedes", 30 });

            migrationBuilder.InsertData(
                table: "Busses",
                columns: new[] { "BusId", "Name", "SeatingCapacity" },
                values: new object[] { 2, "Volvo", 30 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "RouteId" },
                values: new object[] { 1, "İstanbul", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "RouteId" },
                values: new object[] { 2, "Bursa", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "RouteId" },
                values: new object[] { 3, "Bandırma", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "RouteId" },
                values: new object[] { 4, "Biga", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "RouteId" },
                values: new object[] { 5, "Çanakkale", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "RouteId" },
                values: new object[] { 6, "İzmir", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "RouteId" },
                values: new object[] { 7, "Kocaeli", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "RouteId" },
                values: new object[] { 8, "Sakarya", null });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Email", "FirstName", "Gender", "IdentificationNumber", "LastName" },
                values: new object[] { 1, "", "", "E", "1", "" });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "FromWhereId", "ParentRouteId", "Price", "ToWhereId" },
                values: new object[] { 1, 1, null, 250m, 6 });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "FromWhereId", "ParentRouteId", "Price", "ToWhereId" },
                values: new object[] { 2, 1, null, 150m, 5 });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Date", "RouteId", "Time" },
                values: new object[] { 1, "25.12.2022", 1, "00:00" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Date", "RouteId", "Time" },
                values: new object[] { 2, "25.12.2022", 1, "04:00" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "BusId", "PassengerId", "SeatNumber", "TripId" },
                values: new object[] { 1, 1, 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_RouteId",
                table: "Cities",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BusId",
                table: "Tickets",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PassengerId",
                table: "Tickets",
                column: "PassengerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TripId",
                table: "Tickets",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_RouteId",
                table: "Trips",
                column: "RouteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Busses");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
