using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebArg.Storage.MS_SQL.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Masters",
                columns: table => new
                {
                    IsnNode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters", x => x.IsnNode);
                });

            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    IsnNode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.IsnNode);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    IsnNode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsnStudio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastVisit = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.IsnNode);
                    table.ForeignKey(
                        name: "FK_Persons_Studios_IsnStudio",
                        column: x => x.IsnStudio,
                        principalTable: "Studios",
                        principalColumn: "IsnNode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudiosMasters",
                columns: table => new
                {
                    IsnStudio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsnMaster = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudiosMasters", x => new { x.IsnStudio, x.IsnMaster });
                    table.ForeignKey(
                        name: "FK_StudiosMasters_Masters_IsnMaster",
                        column: x => x.IsnMaster,
                        principalTable: "Masters",
                        principalColumn: "IsnNode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudiosMasters_Studios_IsnStudio",
                        column: x => x.IsnStudio,
                        principalTable: "Studios",
                        principalColumn: "IsnNode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MastersPersons",
                columns: table => new
                {
                    IsnMaster = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsnPerson = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MastersPersons", x => new { x.IsnMaster, x.IsnPerson });
                    table.ForeignKey(
                        name: "FK_MastersPersons_Masters_IsnMaster",
                        column: x => x.IsnMaster,
                        principalTable: "Masters",
                        principalColumn: "IsnNode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MastersPersons_Persons_IsnPerson",
                        column: x => x.IsnPerson,
                        principalTable: "Persons",
                        principalColumn: "IsnNode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MastersPersons_IsnMaster_IsnPerson",
                table: "MastersPersons",
                columns: new[] { "IsnMaster", "IsnPerson" });

            migrationBuilder.CreateIndex(
                name: "IX_MastersPersons_IsnPerson",
                table: "MastersPersons",
                column: "IsnPerson");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_IsnStudio",
                table: "Persons",
                column: "IsnStudio");

            migrationBuilder.CreateIndex(
                name: "IX_StudiosMasters_IsnMaster",
                table: "StudiosMasters",
                column: "IsnMaster");

            migrationBuilder.CreateIndex(
                name: "IX_StudiosMasters_IsnStudio_IsnMaster",
                table: "StudiosMasters",
                columns: new[] { "IsnStudio", "IsnMaster" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MastersPersons");

            migrationBuilder.DropTable(
                name: "StudiosMasters");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Masters");

            migrationBuilder.DropTable(
                name: "Studios");
        }
    }
}
