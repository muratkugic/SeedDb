using Microsoft.EntityFrameworkCore.Migrations;

namespace SwapiBackend.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parkinglot",
                columns: table => new
                {
                    SpacePortId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkinglot", x => x.SpacePortId);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    VisitorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.VisitorId);
                });

            migrationBuilder.CreateTable(
                name: "Parkingspot",
                columns: table => new
                {
                    ParkingSpotId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsOccupied = table.Column<bool>(nullable: false),
                    SpacePortId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkingspot", x => x.ParkingSpotId);
                    table.ForeignKey(
                        name: "FK_Parkingspot_Parkinglot_SpacePortId",
                        column: x => x.SpacePortId,
                        principalTable: "Parkinglot",
                        principalColumn: "SpacePortId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Parkinglot",
                columns: new[] { "SpacePortId", "Name" },
                values: new object[] { 1, "Nojjan" });

            migrationBuilder.InsertData(
                table: "Parkingspot",
                columns: new[] { "ParkingSpotId", "IsOccupied", "SpacePortId" },
                values: new object[,]
                {
                    { 1, false, 1 },
                    { 2, false, 1 },
                    { 3, false, 1 },
                    { 4, false, 1 },
                    { 5, false, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parkingspot_SpacePortId",
                table: "Parkingspot",
                column: "SpacePortId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parkingspot");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "Parkinglot");
        }
    }
}
