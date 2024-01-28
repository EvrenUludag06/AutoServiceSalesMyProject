using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoServisSatis.Data.Migrations
{
    /// <inheritdoc />
    public partial class TheEnd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adi", "EklenmeTarihi", "Email", "KullaniciAdi", "Soyadi", "Telefon", "UserGuid" },
                values: new object[] { "Evren", new DateTime(2023, 12, 9, 4, 6, 21, 28, DateTimeKind.Local).AddTicks(751), "Evrenuludag563@gmail.com", "Evren", "Uludag", "0505 903 1910", new Guid("cf46353e-21b1-478a-93a6-fd8a930c9f3b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adi", "EklenmeTarihi", "Email", "KullaniciAdi", "Soyadi", "Telefon", "UserGuid" },
                values: new object[] { "Admin", new DateTime(2023, 11, 30, 21, 14, 36, 196, DateTimeKind.Local).AddTicks(9002), "admin@otoservissatis.tc", "admin", "admin", "0850", new Guid("6f0b6f03-6416-4eec-8d54-bfdf667ce345") });
        }
    }
}
