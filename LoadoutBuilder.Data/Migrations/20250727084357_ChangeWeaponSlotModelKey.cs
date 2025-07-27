using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoadoutBuilder.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeWeaponSlotModelKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeaponSlots_Loadouts_LoadoutId",
                table: "WeaponSlots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponSlots",
                table: "WeaponSlots");

            migrationBuilder.AlterColumn<int>(
                name: "LoadoutId",
                table: "WeaponSlots",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SlotNumber",
                table: "WeaponSlots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponSlots",
                table: "WeaponSlots",
                columns: new[] { "SlotNumber", "LoadoutId" });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponSlots_WeaponId",
                table: "WeaponSlots",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponSlots_Loadouts_LoadoutId",
                table: "WeaponSlots",
                column: "LoadoutId",
                principalTable: "Loadouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeaponSlots_Loadouts_LoadoutId",
                table: "WeaponSlots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponSlots",
                table: "WeaponSlots");

            migrationBuilder.DropIndex(
                name: "IX_WeaponSlots_WeaponId",
                table: "WeaponSlots");

            migrationBuilder.DropColumn(
                name: "SlotNumber",
                table: "WeaponSlots");

            migrationBuilder.AlterColumn<int>(
                name: "LoadoutId",
                table: "WeaponSlots",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponSlots",
                table: "WeaponSlots",
                columns: new[] { "WeaponId", "CamoId", "SightId" });

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponSlots_Loadouts_LoadoutId",
                table: "WeaponSlots",
                column: "LoadoutId",
                principalTable: "Loadouts",
                principalColumn: "Id");
        }
    }
}
