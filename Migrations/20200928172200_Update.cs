using Microsoft.EntityFrameworkCore.Migrations;

namespace SwapiBackend.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisitorParkings",
                columns: table => new
                {
                    ParkingSpotId = table.Column<int>(nullable: false),
                    VisitorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorParkings", x => new { x.ParkingSpotId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_VisitorParkings_Parkingspot_ParkingSpotId",
                        column: x => x.ParkingSpotId,
                        principalTable: "Parkingspot",
                        principalColumn: "ParkingSpotId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorParkings_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "VisitorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisitorParkings_VisitorId",
                table: "VisitorParkings",
                column: "VisitorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitorParkings");
        }
    }
}
