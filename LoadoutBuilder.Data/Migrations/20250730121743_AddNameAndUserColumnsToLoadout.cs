using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoadoutBuilder.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNameAndUserColumnsToLoadout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loadouts_AspNetUsers_ApplicationUserId",
                table: "Loadouts");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Loadouts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Loadouts_ApplicationUserId",
                table: "Loadouts",
                newName: "IX_Loadouts_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Loadouts",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Loadouts_AspNetUsers_UserId",
                table: "Loadouts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loadouts_AspNetUsers_UserId",
                table: "Loadouts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Loadouts");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Loadouts",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Loadouts_UserId",
                table: "Loadouts",
                newName: "IX_Loadouts_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loadouts_AspNetUsers_ApplicationUserId",
                table: "Loadouts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
