using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNI.Migrations
{
    public partial class SecondDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membership_Term_Member_MemberID",
                table: "Membership_Term");

            migrationBuilder.DropIndex(
                name: "IX_Membership_Term_MemberID",
                table: "Membership_Term");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Membership_Term");

            migrationBuilder.AddColumn<int>(
                name: "AdditionalInformation_ID",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BusinessSector_ID",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MembershipTerm_ID",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReferenceInformation_ID",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Member_AdditionalInformation_ID",
                table: "Member",
                column: "AdditionalInformation_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_BusinessSector_ID",
                table: "Member",
                column: "BusinessSector_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_MembershipTerm_ID",
                table: "Member",
                column: "MembershipTerm_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_ReferenceInformation_ID",
                table: "Member",
                column: "ReferenceInformation_ID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_AddtionalInformation_AdditionalInformation_ID",
                table: "Member",
                column: "AdditionalInformation_ID",
                principalTable: "AddtionalInformation",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Business_Sector_BusinessSector_ID",
                table: "Member",
                column: "BusinessSector_ID",
                principalTable: "Business_Sector",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Membership_Term_MembershipTerm_ID",
                table: "Member",
                column: "MembershipTerm_ID",
                principalTable: "Membership_Term",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Reference_Information_ReferenceInformation_ID",
                table: "Member",
                column: "ReferenceInformation_ID",
                principalTable: "Reference_Information",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_AddtionalInformation_AdditionalInformation_ID",
                table: "Member");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Business_Sector_BusinessSector_ID",
                table: "Member");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Membership_Term_MembershipTerm_ID",
                table: "Member");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Reference_Information_ReferenceInformation_ID",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_AdditionalInformation_ID",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_BusinessSector_ID",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_MembershipTerm_ID",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_ReferenceInformation_ID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "AdditionalInformation_ID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "BusinessSector_ID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "MembershipTerm_ID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "ReferenceInformation_ID",
                table: "Member");

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "Membership_Term",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Membership_Term_MemberID",
                table: "Membership_Term",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Membership_Term_Member_MemberID",
                table: "Membership_Term",
                column: "MemberID",
                principalTable: "Member",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
