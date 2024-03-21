using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNI.Migrations
{
    public partial class UpdateContact_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Platform_Platform_Id",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_Platform_Id",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Platform_Id",
                table: "Contact");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PlatformId",
                table: "Contact",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Platform_PlatformId",
                table: "Contact",
                column: "PlatformId",
                principalTable: "Platform",
                principalColumn: "Platform_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Platform_PlatformId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_PlatformId",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "Platform_Id",
                table: "Contact",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Platform_Id",
                table: "Contact",
                column: "Platform_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Platform_Platform_Id",
                table: "Contact",
                column: "Platform_Id",
                principalTable: "Platform",
                principalColumn: "Platform_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
