using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoadoutBuilder.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedSightModelAndValidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponCamos");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Weapons",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Weapons",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Loadouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Loadouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Camos",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Camos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Sight",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Range = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SightCategory",
                columns: table => new
                {
                    SightId = table.Column<int>(type: "int", nullable: false),
                    CotegoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SightCategory", x => new { x.SightId, x.CotegoryId });
                    table.ForeignKey(
                        name: "FK_SightCategory_Categories_CotegoryId",
                        column: x => x.CotegoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SightCategory_Sight_SightId",
                        column: x => x.SightId,
                        principalTable: "Sight",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponSlots",
                columns: table => new
                {
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    CamoId = table.Column<int>(type: "int", nullable: false),
                    SightId = table.Column<int>(type: "int", nullable: false),
                    LoadoutId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponSlots", x => new { x.WeaponId, x.CamoId, x.SightId });
                    table.ForeignKey(
                        name: "FK_WeaponSlots_Camos_CamoId",
                        column: x => x.CamoId,
                        principalTable: "Camos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponSlots_Loadouts_LoadoutId",
                        column: x => x.LoadoutId,
                        principalTable: "Loadouts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WeaponSlots_Sight_SightId",
                        column: x => x.SightId,
                        principalTable: "Sight",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponSlots_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SightCategory_CotegoryId",
                table: "SightCategory",
                column: "CotegoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponSlots_CamoId",
                table: "WeaponSlots",
                column: "CamoId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponSlots_LoadoutId",
                table: "WeaponSlots",
                column: "LoadoutId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponSlots_SightId",
                table: "WeaponSlots",
                column: "SightId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SightCategory");

            migrationBuilder.DropTable(
                name: "WeaponSlots");

            migrationBuilder.DropTable(
                name: "Sight");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Loadouts");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Loadouts");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Weapons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Weapons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Camos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Camos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "WeaponCamos",
                columns: table => new
                {
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    CamoId = table.Column<int>(type: "int", nullable: false),
                    LoadoutId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponCamos", x => new { x.WeaponId, x.CamoId });
                    table.ForeignKey(
                        name: "FK_WeaponCamos_Camos_CamoId",
                        column: x => x.CamoId,
                        principalTable: "Camos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponCamos_Loadouts_LoadoutId",
                        column: x => x.LoadoutId,
                        principalTable: "Loadouts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WeaponCamos_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponCamos_CamoId",
                table: "WeaponCamos",
                column: "CamoId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponCamos_LoadoutId",
                table: "WeaponCamos",
                column: "LoadoutId");
        }
    }
}
