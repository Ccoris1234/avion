using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Avioane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cariera_hotels_hotelId",
                table: "cariera");

            migrationBuilder.DropForeignKey(
                name: "FK_cariera_rezervari_rezervareId",
                table: "cariera");

            migrationBuilder.DropForeignKey(
                name: "FK_mesaje_hotels_hotelId",
                table: "mesaje");

            migrationBuilder.DropForeignKey(
                name: "FK_rezervari_hotels_hotelId",
                table: "rezervari");

            migrationBuilder.DropIndex(
                name: "IX_rezervari_hotelId",
                table: "rezervari");

            migrationBuilder.DropIndex(
                name: "IX_mesaje_hotelId",
                table: "mesaje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hotels",
                table: "hotels");

            migrationBuilder.DropIndex(
                name: "IX_cariera_hotelId",
                table: "cariera");

            migrationBuilder.DropIndex(
                name: "IX_cariera_rezervareId",
                table: "cariera");

            migrationBuilder.DropColumn(
                name: "adulti",
                table: "rezervari");

            migrationBuilder.DropColumn(
                name: "copii",
                table: "rezervari");

            migrationBuilder.DropColumn(
                name: "hotelId",
                table: "rezervari");

            migrationBuilder.DropColumn(
                name: "hotelId",
                table: "mesaje");

            migrationBuilder.DropColumn(
                name: "hotelId",
                table: "hotels");

            migrationBuilder.DropColumn(
                name: "hotelId",
                table: "cariera");

            migrationBuilder.DropColumn(
                name: "rezervareId",
                table: "cariera");

            migrationBuilder.DropColumn(
                name: "allinclusive",
                table: "beneficiis");

            migrationBuilder.DropColumn(
                name: "piscina",
                table: "beneficiis");

            migrationBuilder.AddColumn<int>(
                name: "Nrbilete",
                table: "rezervari",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "avionId",
                table: "rezervari",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "clasa",
                table: "rezervari",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "avionId",
                table: "mesaje",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "avionId",
                table: "hotels",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "avionId",
                table: "cariera",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "bauturi",
                table: "beneficiis",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mancare",
                table: "beneficiis",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_hotels",
                table: "hotels",
                column: "avionId");

            migrationBuilder.CreateIndex(
                name: "IX_rezervari_avionId",
                table: "rezervari",
                column: "avionId");

            migrationBuilder.CreateIndex(
                name: "IX_mesaje_avionId",
                table: "mesaje",
                column: "avionId");

            migrationBuilder.CreateIndex(
                name: "IX_cariera_avionId",
                table: "cariera",
                column: "avionId");

            migrationBuilder.AddForeignKey(
                name: "FK_cariera_hotels_avionId",
                table: "cariera",
                column: "avionId",
                principalTable: "hotels",
                principalColumn: "avionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mesaje_hotels_avionId",
                table: "mesaje",
                column: "avionId",
                principalTable: "hotels",
                principalColumn: "avionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rezervari_hotels_avionId",
                table: "rezervari",
                column: "avionId",
                principalTable: "hotels",
                principalColumn: "avionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cariera_hotels_avionId",
                table: "cariera");

            migrationBuilder.DropForeignKey(
                name: "FK_mesaje_hotels_avionId",
                table: "mesaje");

            migrationBuilder.DropForeignKey(
                name: "FK_rezervari_hotels_avionId",
                table: "rezervari");

            migrationBuilder.DropIndex(
                name: "IX_rezervari_avionId",
                table: "rezervari");

            migrationBuilder.DropIndex(
                name: "IX_mesaje_avionId",
                table: "mesaje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hotels",
                table: "hotels");

            migrationBuilder.DropIndex(
                name: "IX_cariera_avionId",
                table: "cariera");

            migrationBuilder.DropColumn(
                name: "Nrbilete",
                table: "rezervari");

            migrationBuilder.DropColumn(
                name: "avionId",
                table: "rezervari");

            migrationBuilder.DropColumn(
                name: "clasa",
                table: "rezervari");

            migrationBuilder.DropColumn(
                name: "avionId",
                table: "mesaje");

            migrationBuilder.DropColumn(
                name: "avionId",
                table: "hotels");

            migrationBuilder.DropColumn(
                name: "avionId",
                table: "cariera");

            migrationBuilder.DropColumn(
                name: "bauturi",
                table: "beneficiis");

            migrationBuilder.DropColumn(
                name: "mancare",
                table: "beneficiis");

            migrationBuilder.AddColumn<int>(
                name: "adulti",
                table: "rezervari",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "copii",
                table: "rezervari",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "hotelId",
                table: "rezervari",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "hotelId",
                table: "mesaje",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "hotelId",
                table: "hotels",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "hotelId",
                table: "cariera",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "rezervareId",
                table: "cariera",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "allinclusive",
                table: "beneficiis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "piscina",
                table: "beneficiis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_hotels",
                table: "hotels",
                column: "hotelId");

            migrationBuilder.CreateIndex(
                name: "IX_rezervari_hotelId",
                table: "rezervari",
                column: "hotelId");

            migrationBuilder.CreateIndex(
                name: "IX_mesaje_hotelId",
                table: "mesaje",
                column: "hotelId");

            migrationBuilder.CreateIndex(
                name: "IX_cariera_hotelId",
                table: "cariera",
                column: "hotelId");

            migrationBuilder.CreateIndex(
                name: "IX_cariera_rezervareId",
                table: "cariera",
                column: "rezervareId");

            migrationBuilder.AddForeignKey(
                name: "FK_cariera_hotels_hotelId",
                table: "cariera",
                column: "hotelId",
                principalTable: "hotels",
                principalColumn: "hotelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cariera_rezervari_rezervareId",
                table: "cariera",
                column: "rezervareId",
                principalTable: "rezervari",
                principalColumn: "rezervareId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_mesaje_hotels_hotelId",
                table: "mesaje",
                column: "hotelId",
                principalTable: "hotels",
                principalColumn: "hotelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rezervari_hotels_hotelId",
                table: "rezervari",
                column: "hotelId",
                principalTable: "hotels",
                principalColumn: "hotelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
