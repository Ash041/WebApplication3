using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
           name: "Watering_The_Beds",
           columns: table => new
           {
               PrimaryID = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
               date = table.Column<DateTime>(type: "datetime2", nullable: false),
               id = table.Column<int>(type: "int", nullable: false),
               state = table.Column<int>(type: "int", nullable: true)
           },
           constraints: table =>
           {
               table.PrimaryKey("PK_Watering_The_Beds", x => x.PrimaryID);
           });

            migrationBuilder.CreateTable(
            name: "Window_Opening_Drive",
            columns: table => new
            {
                PrimaryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                date = table.Column<DateTime>(type: "datetime2", nullable: false),
                state = table.Column<int>(type: "int", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Window_Opening_Drive", x => x.PrimaryID);
            });
            migrationBuilder.CreateTable(
                name: "Humidification",
                columns: table => new
                {
                    PrimaryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    state = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Humidification", x => x.PrimaryID);
                });

            migrationBuilder.CreateTable(
                name: "Soil_Moisture",
                columns: table => new
                {
                    PrimaryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    humidity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soil_Moisture", x => x.PrimaryID);
                });

            migrationBuilder.CreateTable(
                name: "obj_Temp_And_Humidity",
                columns: table => new
                {
                    PrimaryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    humidity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temp_And_Humidity", x => x.PrimaryID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
              name: "Humidification");

            migrationBuilder.DropTable(
                name: "Soil_Moisture");

            migrationBuilder.DropTable(
                name: "obj_Temp_And_Humidity");

            migrationBuilder.DropTable(
              name: "Watering_The_Beds");

            migrationBuilder.DropTable(
              name: "Window_Opening_Drive");
        }
    }
}
