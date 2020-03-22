using Microsoft.EntityFrameworkCore.Migrations;

namespace AerolineaV1.Migrations.Reservacion
{
    public partial class FiveCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservaciones",
                columns: table => new
                {
                    ReservaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(type: "varchar(30)", nullable: false),
                    PaisDestino = table.Column<string>(type: "varchar(20)", nullable: false),
                    CategoriaVuelo = table.Column<string>(type: "varchar(10)", nullable: true),
                    PosAsiento = table.Column<string>(type: "char", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservaciones", x => x.ReservaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservaciones");
        }
    }
}
