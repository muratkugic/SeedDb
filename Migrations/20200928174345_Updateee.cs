using Microsoft.EntityFrameworkCore.Migrations;

namespace SwapiBackend.Migrations
{
    public partial class Updateee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitorParkings_Parkingspot_ParkingSpotId",
                table: "VisitorParkings");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorParkings_Visitors_VisitorId",
                table: "VisitorParkings");

            migrationBuilder.DropIndex(
                name: "IX_VisitorParkings_VisitorId",
                table: "VisitorParkings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_VisitorParkings_VisitorId",
                table: "VisitorParkings",
                column: "VisitorId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorParkings_Parkingspot_ParkingSpotId",
                table: "VisitorParkings",
                column: "ParkingSpotId",
                principalTable: "Parkingspot",
                principalColumn: "ParkingSpotId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorParkings_Visitors_VisitorId",
                table: "VisitorParkings",
                column: "VisitorId",
                principalTable: "Visitors",
                principalColumn: "VisitorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
