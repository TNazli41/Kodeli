using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kodeli.Migrations
{
    public partial class db__ds__ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tanimlar_TanimlarTur_tanimlarTurId",
                table: "Tanimlar");

            migrationBuilder.AlterColumn<bool>(
                name: "AltifMi",
                table: "TanimlarTur",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "TanimlarTur",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GuncellemeTarihi",
                table: "TanimlarTur",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuncelleyenKullanici",
                table: "TanimlarTur",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IpAdresi",
                table: "TanimlarTur",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KaydedenKullanici",
                table: "TanimlarTur",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "KayitTarihi",
                table: "TanimlarTur",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AltifMi",
                table: "Tanimlar",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateTime>(
                name: "GuncellemeTarihi",
                table: "Tanimlar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuncelleyenKullanici",
                table: "Tanimlar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IpAdresi",
                table: "Tanimlar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KaydedenKullanici",
                table: "Tanimlar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "KayitTarihi",
                table: "Tanimlar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ulke",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AltifMi = table.Column<bool>(type: "bit", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KaydedenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulke", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YarismaTanim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    YarismaTuruId = table.Column<int>(type: "int", nullable: false),
                    Kontenjan = table.Column<int>(type: "int", nullable: true),
                    AltifMi = table.Column<bool>(type: "bit", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KaydedenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YarismaTanim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YarismaTanim_Tanimlar_YarismaTuruId",
                        column: x => x.YarismaTuruId,
                        principalTable: "Tanimlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Il",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IlKodu = table.Column<int>(type: "int", nullable: false),
                    UlkeId = table.Column<int>(type: "int", nullable: false),
                    AltifMi = table.Column<bool>(type: "bit", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KaydedenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Il", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Il_Ulke_UlkeId",
                        column: x => x.UlkeId,
                        principalTable: "Ulke",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ilce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IlceKodu = table.Column<int>(type: "int", nullable: false),
                    IlId = table.Column<int>(type: "int", nullable: false),
                    AltifMi = table.Column<bool>(type: "bit", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KaydedenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilce_Il_IlId",
                        column: x => x.IlId,
                        principalTable: "Il",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Okul",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OkulTuruId = table.Column<int>(type: "int", nullable: false),
                    IlceId = table.Column<int>(type: "int", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KaydedenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okul", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Okul_Ilce_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilce",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Okul_Tanimlar_OkulTuruId",
                        column: x => x.OkulTuruId,
                        principalTable: "Tanimlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Basvuru",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CinsiyetId = table.Column<int>(type: "int", nullable: false),
                    OkulId = table.Column<int>(type: "int", nullable: false),
                    YarismaId = table.Column<int>(type: "int", nullable: false),
                    DogumTairih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VeliAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VeliSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CepTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kvkk = table.Column<bool>(type: "bit", nullable: true),
                    Sartname = table.Column<bool>(type: "bit", nullable: true),
                    AltifMi = table.Column<bool>(type: "bit", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KaydedenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basvuru", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Basvuru_Okul_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okul",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Basvuru_Tanimlar_CinsiyetId",
                        column: x => x.CinsiyetId,
                        principalTable: "Tanimlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Basvuru_YarismaTanim_YarismaId",
                        column: x => x.YarismaId,
                        principalTable: "YarismaTanim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Basvuru_CinsiyetId",
                table: "Basvuru",
                column: "CinsiyetId");

            migrationBuilder.CreateIndex(
                name: "IX_Basvuru_OkulId",
                table: "Basvuru",
                column: "OkulId");

            migrationBuilder.CreateIndex(
                name: "IX_Basvuru_YarismaId",
                table: "Basvuru",
                column: "YarismaId");

            migrationBuilder.CreateIndex(
                name: "IX_Il_UlkeId",
                table: "Il",
                column: "UlkeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilce_IlId",
                table: "Ilce",
                column: "IlId");

            migrationBuilder.CreateIndex(
                name: "IX_Okul_IlceId",
                table: "Okul",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Okul_OkulTuruId",
                table: "Okul",
                column: "OkulTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_YarismaTanim_YarismaTuruId",
                table: "YarismaTanim",
                column: "YarismaTuruId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tanimlar_TanimlarTur_tanimlarTurId",
                table: "Tanimlar",
                column: "tanimlarTurId",
                principalTable: "TanimlarTur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tanimlar_TanimlarTur_tanimlarTurId",
                table: "Tanimlar");

            migrationBuilder.DropTable(
                name: "Basvuru");

            migrationBuilder.DropTable(
                name: "Okul");

            migrationBuilder.DropTable(
                name: "YarismaTanim");

            migrationBuilder.DropTable(
                name: "Ilce");

            migrationBuilder.DropTable(
                name: "Il");

            migrationBuilder.DropTable(
                name: "Ulke");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "TanimlarTur");

            migrationBuilder.DropColumn(
                name: "GuncellemeTarihi",
                table: "TanimlarTur");

            migrationBuilder.DropColumn(
                name: "GuncelleyenKullanici",
                table: "TanimlarTur");

            migrationBuilder.DropColumn(
                name: "IpAdresi",
                table: "TanimlarTur");

            migrationBuilder.DropColumn(
                name: "KaydedenKullanici",
                table: "TanimlarTur");

            migrationBuilder.DropColumn(
                name: "KayitTarihi",
                table: "TanimlarTur");

            migrationBuilder.DropColumn(
                name: "GuncellemeTarihi",
                table: "Tanimlar");

            migrationBuilder.DropColumn(
                name: "GuncelleyenKullanici",
                table: "Tanimlar");

            migrationBuilder.DropColumn(
                name: "IpAdresi",
                table: "Tanimlar");

            migrationBuilder.DropColumn(
                name: "KaydedenKullanici",
                table: "Tanimlar");

            migrationBuilder.DropColumn(
                name: "KayitTarihi",
                table: "Tanimlar");

            migrationBuilder.AlterColumn<bool>(
                name: "AltifMi",
                table: "TanimlarTur",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AltifMi",
                table: "Tanimlar",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tanimlar_TanimlarTur_tanimlarTurId",
                table: "Tanimlar",
                column: "tanimlarTurId",
                principalTable: "TanimlarTur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
