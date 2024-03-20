using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNI.Migrations
{
    public partial class ListMemberForBussinesSector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Member_BusinessSector_ID",
                table: "Member");

            migrationBuilder.CreateIndex(
                name: "IX_Member_BusinessSector_ID",
                table: "Member",
                column: "BusinessSector_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Member_BusinessSector_ID",
                table: "Member");

            migrationBuilder.CreateIndex(
                name: "IX_Member_BusinessSector_ID",
                table: "Member",
                column: "BusinessSector_ID",
                unique: true);
        }
    }
}
