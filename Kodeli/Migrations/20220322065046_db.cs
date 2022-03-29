using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kodeli.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TanimlarTur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AltifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TanimlarTur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tanimlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AltifMi = table.Column<bool>(type: "bit", nullable: false),
                    tanimlarTurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanimlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tanimlar_TanimlarTur_tanimlarTurId",
                        column: x => x.tanimlarTurId,
                        principalTable: "TanimlarTur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tanimlar_tanimlarTurId",
                table: "Tanimlar",
                column: "tanimlarTurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tanimlar");

            migrationBuilder.DropTable(
                name: "TanimlarTur");
        }
    }
}
