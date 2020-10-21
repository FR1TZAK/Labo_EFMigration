using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositories.Migrations
{
    public partial class TryAddNewTable_Catering_DbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catering",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catering", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Catering_Flight_FlightID",
                        column: x => x.FlightID,
                        principalSchema: "dbo",
                        principalTable: "Flight",
                        principalColumn: "FlightNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Catering_FlightID",
                schema: "dbo",
                table: "Catering",
                column: "FlightID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catering",
                schema: "dbo");
        }
    }
}
