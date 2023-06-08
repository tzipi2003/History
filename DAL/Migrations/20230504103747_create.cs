using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FromYear = table.Column<int>(type: "int", nullable: true),
                    ToYear = table.Column<int>(type: "int", nullable: true),
                    StateBorders = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Country__10D1609F0DAE7E3E", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiteleEvent = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    EDescription = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    ECity = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EYear = table.Column<int>(type: "int", nullable: true),
                    EventDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Events__7944C810033C6CC2", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PeopleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeopleName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    PeopleRole = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeathDate = table.Column<DateTime>(type: "date", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__People__2B24391C3B8A9B2E", x => x.PeopleId);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Country__E056F20197D93E2C",
                table: "Country",
                column: "CountryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Events__86C17744AEF4CE68",
                table: "Events",
                column: "TiteleEvent",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__People__2DC9F30E0FD0D2F5",
                table: "People",
                column: "PeopleName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
