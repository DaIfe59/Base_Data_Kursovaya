using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kursovaya.Migrations
{
    /// <inheritdoc />
    public partial class initialmigr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rnr = table.Column<float>(type: "real", nullable: false),
                    b1 = table.Column<float>(type: "real", nullable: false),
                    z2 = table.Column<float>(type: "real", nullable: false),
                    rmosh = table.Column<float>(type: "real", nullable: false),
                    zp = table.Column<float>(type: "real", nullable: false),
                    t = table.Column<float>(type: "real", nullable: false),
                    i = table.Column<float>(type: "real", nullable: false),
                    mddn = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vivods",
                columns: table => new
                {
                    ID1 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vivods", x => x.ID1);
                    table.ForeignKey(
                        name: "FK_Vivods_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vivods_TableId",
                table: "Vivods",
                column: "TableId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vivods");

            migrationBuilder.DropTable(
                name: "Tables");
        }
    }
}
