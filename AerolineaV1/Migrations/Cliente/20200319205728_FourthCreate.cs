using Microsoft.EntityFrameworkCore.Migrations;

namespace AerolineaV1.Migrations.Cliente
{
    public partial class FourthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pasaporte = table.Column<string>(type: "varchar(30)", nullable: false),
                    Cedula = table.Column<string>(type: "varchar(30)", nullable: false),
                    NombreCompleto = table.Column<string>(type: "varchar(40)", nullable: true),
                    Nacionalidad = table.Column<string>(type: "varchar(20)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
