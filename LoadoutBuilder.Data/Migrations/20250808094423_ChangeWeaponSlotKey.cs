using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoadoutBuilder.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeWeaponSlotKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeaponSlots_Camos_CamoId",
                table: "WeaponSlots");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponSlots_Sight_SightId",
                table: "WeaponSlots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponSlots",
                table: "WeaponSlots");

            migrationBuilder.DropIndex(
                name: "IX_WeaponSlots_LoadoutId",
                table: "WeaponSlots");

            migrationBuilder.RenameColumn(
                name: "SlotNumber",
                table: "WeaponSlots",
                newName: "Type");

            migrationBuilder.AlterColumn<int>(
                name: "SightId",
                table: "WeaponSlots",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CamoId",
                table: "WeaponSlots",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "WeaponSlots",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WeaponSlots",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Range",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponSlots",
                table: "WeaponSlots",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponSlots_LoadoutId_Type",
                table: "WeaponSlots",
                columns: new[] { "LoadoutId", "Type" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponSlots_Camos_CamoId",
                table: "WeaponSlots",
                column: "CamoId",
                principalTable: "Camos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponSlots_Sight_SightId",
                table: "WeaponSlots",
                column: "SightId",
                principalTable: "Sight",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeaponSlots_Camos_CamoId",
                table: "WeaponSlots");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponSlots_Sight_SightId",
                table: "WeaponSlots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponSlots",
                table: "WeaponSlots");

            migrationBuilder.DropIndex(
                name: "IX_WeaponSlots_LoadoutId_Type",
                table: "WeaponSlots");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WeaponSlots");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WeaponSlots");

            migrationBuilder.DropColumn(
                name: "Range",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "WeaponSlots",
                newName: "SlotNumber");

            migrationBuilder.AlterColumn<int>(
                name: "SightId",
                table: "WeaponSlots",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CamoId",
                table: "WeaponSlots",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponSlots",
                table: "WeaponSlots",
                columns: new[] { "SlotNumber", "LoadoutId" });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponSlots_LoadoutId",
                table: "WeaponSlots",
                column: "LoadoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponSlots_Camos_CamoId",
                table: "WeaponSlots",
                column: "CamoId",
                principalTable: "Camos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponSlots_Sight_SightId",
                table: "WeaponSlots",
                column: "SightId",
                principalTable: "Sight",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
