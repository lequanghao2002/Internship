using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNI.Migrations
{
    public partial class Events : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "EventTitle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventTitle_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TitleImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventTitleId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TitleImage_EventTitle_EventTitleId",
                        column: x => x.EventTitleId,
                        principalTable: "EventTitle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1a9c1392-acd7-40e5-a785-31ac3e8be002");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c4f8f358-eafb-45df-b8ca-5e8be0c28314");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4e2ca6f1-8c69-44a1-ab1a-147677942e31");

            migrationBuilder.CreateIndex(
                name: "IX_EventTitle_EventId",
                table: "EventTitle",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleImage_EventTitleId",
                table: "TitleImage",
                column: "EventTitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Events",
                newName: "ID");

           


            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "75a5e437-8b3d-4ca9-ac44-2a7267ceec67");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2360b366-aa66-409c-bad8-1e291f56f759");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "33c5fb16-6dc8-4166-b4ee-88ff153d11f5");
        }
    }
}
