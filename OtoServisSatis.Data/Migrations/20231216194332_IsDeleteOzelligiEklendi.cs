using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoServisSatis.Data.Migrations
{
    /// <inheritdoc />
    public partial class IsDeleteOzelligiEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Sliders",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Servisler",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Satislar",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Roller",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Musteriler",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Markalar",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Kullanicilar",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Araclar",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EklenmeTarihi", "IsDelete", "UserGuid" },
                values: new object[] { new DateTime(2023, 12, 16, 22, 43, 31, 924, DateTimeKind.Local).AddTicks(7110), false, new Guid("72beeaab-821b-41a7-8893-a85c81c63194") });

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDelete",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Satislar");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Roller");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Musteriler");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Markalar");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Araclar");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EklenmeTarihi", "UserGuid" },
                values: new object[] { new DateTime(2023, 12, 9, 4, 6, 21, 28, DateTimeKind.Local).AddTicks(751), new Guid("cf46353e-21b1-478a-93a6-fd8a930c9f3b") });
        }
    }
}
