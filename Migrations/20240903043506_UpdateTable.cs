using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iguaman.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alamat1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Alamat2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Alamat3",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AlamatPejabat",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "TarikhDicipta",
                table: "AspNetUsers",
                newName: "TarikhCipta");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "AspNetUsers",
                newName: "NoPengenalan");

            migrationBuilder.RenameColumn(
                name: "IdPeranan",
                table: "AspNetUsers",
                newName: "JenisPengenalan");

            migrationBuilder.RenameColumn(
                name: "IdPengguna",
                table: "AspNetUsers",
                newName: "AlamatTetap3");

            migrationBuilder.RenameColumn(
                name: "IdNegeri",
                table: "AspNetUsers",
                newName: "AlamatTetap2");

            migrationBuilder.RenameColumn(
                name: "IdCawangan",
                table: "AspNetUsers",
                newName: "AlamatTetap1");

            migrationBuilder.AddColumn<Guid>(
                name: "CawanganJbgId",
                table: "AspNetUsers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsPegawai",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "NegeriId",
                table: "AspNetUsers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PerananId",
                table: "AspNetUsers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "StatusPengguna",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Cawangans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NamaCawangan = table.Column<string>(type: "text", nullable: true),
                    KodCawangan = table.Column<string>(type: "text", nullable: true),
                    StatusJBG = table.Column<bool>(type: "boolean", nullable: false),
                    Alamat1 = table.Column<string>(type: "text", nullable: true),
                    Alamat2 = table.Column<string>(type: "text", nullable: true),
                    Alamat3 = table.Column<string>(type: "text", nullable: true),
                    Poskod = table.Column<string>(type: "text", nullable: true),
                    NoTel = table.Column<string>(type: "text", nullable: true),
                    IdNegeri = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cawangans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JenisKess",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Jenis_Kes = table.Column<string>(type: "text", nullable: true),
                    IdKategori = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisKess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    JenisKategori = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhidmatNasihats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    JenisPermohonan = table.Column<string>(type: "text", nullable: true),
                    JenisKes = table.Column<string>(type: "text", nullable: true),
                    NamaMangsa = table.Column<string>(type: "text", nullable: true),
                    IdPengenalanMangsa = table.Column<string>(type: "text", nullable: true),
                    JenisPengenalanMangsa = table.Column<string>(type: "text", nullable: true),
                    JantinaMangsa = table.Column<string>(type: "text", nullable: true),
                    UmurMangsa = table.Column<string>(type: "text", nullable: true),
                    Bangsa = table.Column<string>(type: "text", nullable: true),
                    Agama = table.Column<string>(type: "text", nullable: true),
                    TarikhLahirMangsa = table.Column<DateOnly>(type: "date", nullable: false),
                    NamaWakil = table.Column<string>(type: "text", nullable: true),
                    AnakNo = table.Column<string>(type: "text", nullable: true),
                    AlamatSurat1 = table.Column<string>(type: "text", nullable: true),
                    AlamatSurat2 = table.Column<string>(type: "text", nullable: true),
                    AlamatSurat3 = table.Column<string>(type: "text", nullable: true),
                    Poskod = table.Column<string>(type: "text", nullable: true),
                    Perakuan = table.Column<bool>(type: "boolean", nullable: false),
                    TarikhCipta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CiptaOleh = table.Column<string>(type: "text", nullable: true),
                    TarikhKemaskini = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    KemaskiniOleh = table.Column<string>(type: "text", nullable: true),
                    JumlahBayaran = table.Column<double>(type: "double precision", nullable: false),
                    StatusBayaran = table.Column<bool>(type: "boolean", nullable: false),
                    UlasanPermohonan = table.Column<string>(type: "text", nullable: true),
                    UlasanPegawai = table.Column<string>(type: "text", nullable: true),
                    StatusKN = table.Column<string>(type: "text", nullable: true),
                    IdTemuJanji = table.Column<Guid>(type: "uuid", nullable: false),
                    IdPengguna = table.Column<Guid>(type: "uuid", nullable: false),
                    IdKategori = table.Column<Guid>(type: "uuid", nullable: false),
                    IdNegeri = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhidmatNasihats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Negeris",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NamaNegeri = table.Column<string>(type: "text", nullable: true),
                    KodNegeri = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negeris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemuJanjis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TarikhTemuJanji = table.Column<DateOnly>(type: "date", nullable: false),
                    MasaMulaTemuJanji = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    MasaAkhirTemuJanji = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    TempatTemuJanji = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    TarikhCipta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CiptaOleh = table.Column<string>(type: "text", nullable: true),
                    TarikhKemaskini = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    KemaskiniOleh = table.Column<string>(type: "text", nullable: true),
                    IdKhidmatNasihat = table.Column<Guid>(type: "uuid", nullable: false),
                    CawanganJBG = table.Column<Guid>(type: "uuid", nullable: false),
                    IdPegawaiKN = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemuJanjis", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cawangans");

            migrationBuilder.DropTable(
                name: "JenisKess");

            migrationBuilder.DropTable(
                name: "Kategoris");

            migrationBuilder.DropTable(
                name: "KhidmatNasihats");

            migrationBuilder.DropTable(
                name: "Negeris");

            migrationBuilder.DropTable(
                name: "TemuJanjis");

            migrationBuilder.DropColumn(
                name: "CawanganJbgId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsPegawai",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NegeriId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PerananId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StatusPengguna",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.RenameColumn(
                name: "TarikhCipta",
                table: "AspNetUsers",
                newName: "TarikhDicipta");

            migrationBuilder.RenameColumn(
                name: "NoPengenalan",
                table: "AspNetUsers",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "JenisPengenalan",
                table: "AspNetUsers",
                newName: "IdPeranan");

            migrationBuilder.RenameColumn(
                name: "AlamatTetap3",
                table: "AspNetUsers",
                newName: "IdPengguna");

            migrationBuilder.RenameColumn(
                name: "AlamatTetap2",
                table: "AspNetUsers",
                newName: "IdNegeri");

            migrationBuilder.RenameColumn(
                name: "AlamatTetap1",
                table: "AspNetUsers",
                newName: "IdCawangan");

            migrationBuilder.AddColumn<string>(
                name: "Alamat1",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alamat2",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alamat3",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlamatPejabat",
                table: "AspNetUsers",
                type: "text",
                nullable: true);
        }
    }
}
