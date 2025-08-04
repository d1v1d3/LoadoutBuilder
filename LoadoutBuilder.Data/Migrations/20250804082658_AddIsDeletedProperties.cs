using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoadoutBuilder.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsDeletedProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Weapons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sight",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Loadouts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Camos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sight");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Loadouts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Camos");
        }
    }
}
