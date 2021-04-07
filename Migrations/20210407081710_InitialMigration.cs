using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hotels",
                columns: table => new
                {
                    hotelid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotels", x => x.hotelid);
                });

            migrationBuilder.CreateTable(
                name: "mesaje",
                columns: table => new
                {
                    mesajid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    hotelid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mesaje", x => x.mesajid);
                    table.ForeignKey(
                        name: "FK_mesaje_hotels_hotelid",
                        column: x => x.hotelid,
                        principalTable: "hotels",
                        principalColumn: "hotelid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mesaje_hotelid",
                table: "mesaje",
                column: "hotelid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mesaje");

            migrationBuilder.DropTable(
                name: "hotels");
        }
    }
}
