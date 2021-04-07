using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_mesaje_hotels_hotelid",
                table: "mesaje");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "mesaje");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "mesaje");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "hotels");

            migrationBuilder.RenameColumn(
                name: "hotelid",
                table: "mesaje",
                newName: "hotelId");

            migrationBuilder.RenameColumn(
                name: "mesajid",
                table: "mesaje",
                newName: "mesajId");

            migrationBuilder.RenameIndex(
                name: "IX_mesaje_hotelid",
                table: "mesaje",
                newName: "IX_mesaje_hotelId");

            migrationBuilder.RenameColumn(
                name: "hotelid",
                table: "hotels",
                newName: "hotelId");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "mesaje",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nume",
                table: "mesaje",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "prenume",
                table: "mesaje",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "text",
                table: "mesaje",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "locatia",
                table: "hotels",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "rezervari",
                columns: table => new
                {
                    rezervareId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(nullable: true),
                    prenume = table.Column<string>(nullable: true),
                    copii = table.Column<int>(nullable: false),
                    adulti = table.Column<int>(nullable: false),
                    hotelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rezervari", x => x.rezervareId);
                    table.ForeignKey(
                        name: "FK_rezervari_hotels_hotelId",
                        column: x => x.hotelId,
                        principalTable: "hotels",
                        principalColumn: "hotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "beneficiis",
                columns: table => new
                {
                    beneficiiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    allinclusive = table.Column<string>(nullable: true),
                    piscina = table.Column<string>(nullable: true),
                    rezervareId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_beneficiis", x => x.beneficiiId);
                    table.ForeignKey(
                        name: "FK_beneficiis_rezervari_rezervareId",
                        column: x => x.rezervareId,
                        principalTable: "rezervari",
                        principalColumn: "rezervareId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cariera",
                columns: table => new
                {
                    carieraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(nullable: true),
                    prenume = table.Column<string>(nullable: true),
                    calitati = table.Column<string>(nullable: true),
                    hotelId = table.Column<int>(nullable: false),
                    rezervareId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cariera", x => x.carieraId);
                    table.ForeignKey(
                        name: "FK_cariera_hotels_hotelId",
                        column: x => x.hotelId,
                        principalTable: "hotels",
                        principalColumn: "hotelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cariera_rezervari_rezervareId",
                        column: x => x.rezervareId,
                        principalTable: "rezervari",
                        principalColumn: "rezervareId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "joburi",
                columns: table => new
                {
                    jobId = table.Column<string>(nullable: false),
                    numejob = table.Column<string>(nullable: true),
                    experienta = table.Column<string>(nullable: true),
                    carieraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_joburi", x => x.jobId);
                    table.ForeignKey(
                        name: "FK_joburi_cariera_carieraId",
                        column: x => x.carieraId,
                        principalTable: "cariera",
                        principalColumn: "carieraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_beneficiis_rezervareId",
                table: "beneficiis",
                column: "rezervareId");

            migrationBuilder.CreateIndex(
                name: "IX_cariera_hotelId",
                table: "cariera",
                column: "hotelId");

            migrationBuilder.CreateIndex(
                name: "IX_cariera_rezervareId",
                table: "cariera",
                column: "rezervareId");

            migrationBuilder.CreateIndex(
                name: "IX_joburi_carieraId",
                table: "joburi",
                column: "carieraId");

            migrationBuilder.CreateIndex(
                name: "IX_rezervari_hotelId",
                table: "rezervari",
                column: "hotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_mesaje_hotels_hotelId",
                table: "mesaje",
                column: "hotelId",
                principalTable: "hotels",
                principalColumn: "hotelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_mesaje_hotels_hotelId",
                table: "mesaje");

            migrationBuilder.DropTable(
                name: "beneficiis");

            migrationBuilder.DropTable(
                name: "joburi");

            migrationBuilder.DropTable(
                name: "cariera");

            migrationBuilder.DropTable(
                name: "rezervari");

            migrationBuilder.DropColumn(
                name: "email",
                table: "mesaje");

            migrationBuilder.DropColumn(
                name: "nume",
                table: "mesaje");

            migrationBuilder.DropColumn(
                name: "prenume",
                table: "mesaje");

            migrationBuilder.DropColumn(
                name: "text",
                table: "mesaje");

            migrationBuilder.DropColumn(
                name: "locatia",
                table: "hotels");

            migrationBuilder.RenameColumn(
                name: "hotelId",
                table: "mesaje",
                newName: "hotelid");

            migrationBuilder.RenameColumn(
                name: "mesajId",
                table: "mesaje",
                newName: "mesajid");

            migrationBuilder.RenameIndex(
                name: "IX_mesaje_hotelId",
                table: "mesaje",
                newName: "IX_mesaje_hotelid");

            migrationBuilder.RenameColumn(
                name: "hotelId",
                table: "hotels",
                newName: "hotelid");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "mesaje",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "mesaje",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_mesaje_hotels_hotelid",
                table: "mesaje",
                column: "hotelid",
                principalTable: "hotels",
                principalColumn: "hotelid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
