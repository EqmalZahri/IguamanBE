using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iguaman.Migrations
{
    /// <inheritdoc />
    public partial class PenjaraAndJkmTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JKMs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NamaCawanganJKM = table.Column<string>(type: "text", nullable: true),
                    KodCawanganJKM = table.Column<string>(type: "text", nullable: true),
                    StatusCawanganJKM = table.Column<bool>(type: "boolean", nullable: false),
                    Alamat1 = table.Column<string>(type: "text", nullable: true),
                    Alamat2 = table.Column<string>(type: "text", nullable: true),
                    Alamat3 = table.Column<string>(type: "text", nullable: true),
                    Poskod = table.Column<string>(type: "text", nullable: true),
                    NoTel = table.Column<string>(type: "text", nullable: true),
                    IdNegeri = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JKMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Penjaras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NamaCawanganPenjara = table.Column<string>(type: "text", nullable: true),
                    KodCawanganPenjara = table.Column<string>(type: "text", nullable: true),
                    StatusCawanganPenjara = table.Column<bool>(type: "boolean", nullable: false),
                    Alamat1 = table.Column<string>(type: "text", nullable: true),
                    Alamat2 = table.Column<string>(type: "text", nullable: true),
                    Alamat3 = table.Column<string>(type: "text", nullable: true),
                    Poskod = table.Column<string>(type: "text", nullable: true),
                    NoTel = table.Column<string>(type: "text", nullable: true),
                    IdNegeri = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penjaras", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JKMs");

            migrationBuilder.DropTable(
                name: "Penjaras");
        }
    }
}
