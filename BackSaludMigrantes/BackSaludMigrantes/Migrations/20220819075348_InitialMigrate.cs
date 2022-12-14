using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackSaludMigrantes.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LOCALIDAD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOCALIDAD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MIGRANTES_ACREDITADOM",
                columns: table => new
                {
                    ID_MIGRANTE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DOC_TIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOC_NUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    APELLIDO_A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    APELLIDO_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOMBRE_A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOMBRE_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FEC_NAC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FICHA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOCALIDAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARENTESCO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIR_VIVIENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUCLEO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MIGRANTES_ACREDITADOM", x => x.ID_MIGRANTE);
                });

            migrationBuilder.CreateTable(
                name: "DECLARACIONES_MIGRANTES",
                columns: table => new
                {
                    FICHA_SISBEN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DIRECCION = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TELEFONO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LOCALIDAD = table.Column<int>(type: "int", nullable: true),
                    FECHA_DECLARA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FECHA_VIGENCIA = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DECLARACIONES_MIGRANTES", x => x.FICHA_SISBEN);
                    table.ForeignKey(
                        name: "FK_DECLARACIONES_MIGRANTES_LOCALIDAD_LOCALIDAD",
                        column: x => x.LOCALIDAD,
                        principalTable: "LOCALIDAD",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "LOCALIDAD",
                columns: new[] { "ID", "NOMBRE" },
                values: new object[,]
                {
                    { 1, "01. USAQUÉN" },
                    { 2, "02. CHAPINERO" },
                    { 3, "03. SANTA FE" },
                    { 4, "04. SAN CRISTOBAL" },
                    { 5, "05. USME" },
                    { 6, "06. TUNJUELITO" },
                    { 7, "07. BOSA" },
                    { 8, "08. KENNEDY" },
                    { 9, "09. FONTIBÓN" },
                    { 10, "10. ENGATIVÁ" },
                    { 11, "11. SUBA" },
                    { 12, "12. BARRIOS UNIDOS" },
                    { 13, "13. TEUSAQUILLO" },
                    { 14, "14. MÁRTIRES" },
                    { 15, "15. ANTONIO NARIÑO" },
                    { 16, "16. PUENTE ARANDA" },
                    { 17, "17. CANDELARIA" },
                    { 18, "18. RAFAEL URIBE" },
                    { 19, "19. CIUDAD BOLIVAR" },
                    { 29, "20. SUMAPAZ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DECLARACIONES_MIGRANTES_LOCALIDAD",
                table: "DECLARACIONES_MIGRANTES",
                column: "LOCALIDAD");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DECLARACIONES_MIGRANTES");

            migrationBuilder.DropTable(
                name: "MIGRANTES_ACREDITADOM");

            migrationBuilder.DropTable(
                name: "LOCALIDAD");
        }
    }
}
