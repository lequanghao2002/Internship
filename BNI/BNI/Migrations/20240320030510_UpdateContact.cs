using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNI.Migrations
{
    public partial class UpdateContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Contact",
                newName: "Position");

            migrationBuilder.AlterColumn<string>(
                name: "SupportInformation",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Contact",
                newName: "Message");

            migrationBuilder.AlterColumn<bool>(
                name: "SupportInformation",
                table: "Contact",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
