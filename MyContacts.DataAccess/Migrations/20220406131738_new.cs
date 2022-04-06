using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyContacts.DataAccess.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LabelName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LabelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactDetails_Labels_LabelId",
                        column: x => x.LabelId,
                        principalTable: "Labels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContactNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactDetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactNumbers_ContactDetails_ContactDetailId",
                        column: x => x.ContactDetailId,
                        principalTable: "ContactDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "Id", "LabelName" },
                values: new object[] { 1, "Family" });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "Id", "LabelName" },
                values: new object[] { 2, "School Friends" });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "Id", "LabelName" },
                values: new object[] { 3, "Colleagues" });

            migrationBuilder.InsertData(
                table: "ContactDetails",
                columns: new[] { "Id", "Address", "DateCreated", "DateUpdated", "FirstName", "Image", "IsDeleted", "IsPublished", "LabelId", "LastName", "Notes" },
                values: new object[,]
                {
                    { 1, "8B Court Parade, HA0 3HY", new DateTime(2022, 4, 6, 14, 17, 38, 668, DateTimeKind.Local).AddTicks(5746), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sagar", null, false, true, 2, "Dyola", "Nothing for now" },
                    { 2, "8A Court Parade, HA0 3HY", new DateTime(2022, 4, 6, 14, 17, 38, 668, DateTimeKind.Local).AddTicks(5796), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunita", null, false, true, 3, "Ghale", "Hey this is Sunita Ghale" },
                    { 3, "Lagankhel, Nepal", new DateTime(2022, 4, 6, 14, 17, 38, 668, DateTimeKind.Local).AddTicks(5800), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Surya Lal", null, false, true, 1, "Dyola", "Surya here. Nothing for now" },
                    { 4, "Lagankhel, Nepal", new DateTime(2022, 4, 6, 14, 17, 38, 668, DateTimeKind.Local).AddTicks(5803), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sumitra", null, false, true, 2, "Dyola", "Sumitra here. Nothing for now" },
                    { 5, "Lagankhel, Nepal", new DateTime(2022, 4, 6, 14, 17, 38, 668, DateTimeKind.Local).AddTicks(5807), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunita", null, false, true, 3, "Dyola", "Sunita here. Nothing for now" },
                    { 6, "Samakhushi, Nepal", new DateTime(2022, 4, 6, 14, 17, 38, 668, DateTimeKind.Local).AddTicks(5811), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Subita", null, false, true, 1, "Ghale", "Subita here. Nothing for now" }
                });

            migrationBuilder.InsertData(
                table: "ContactNumbers",
                columns: new[] { "Id", "ContactDetailId", "Number", "Title" },
                values: new object[,]
                {
                    { 1, 1, "+447470855303", "Mobile" },
                    { 2, 1, "+97715536178", "Home" },
                    { 3, 1, "+9779841751478", "Mobile (Nepal)" },
                    { 4, 2, "+447727353665", "Mobile" },
                    { 5, 2, "+97714983404", "Home" },
                    { 6, 3, "+9779851085563", "Mobile" },
                    { 7, 4, "+9779841520663", "Mobile" },
                    { 8, 5, "+9779843335072", "Mobile" },
                    { 9, 6, "+9779810357026", "Mobile" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_LabelId",
                table: "ContactDetails",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactNumbers_ContactDetailId",
                table: "ContactNumbers",
                column: "ContactDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactNumbers");

            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "Labels");
        }
    }
}
