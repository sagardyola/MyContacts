using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyContacts.DataAccess.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 28, 56, 559, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 28, 56, 559, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 28, 56, 559, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 28, 56, 559, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 28, 56, 559, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 28, 56, 559, DateTimeKind.Local).AddTicks(1048));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 26, 14, 710, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 26, 14, 710, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 26, 14, 710, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 26, 14, 710, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 26, 14, 710, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "ContactDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 4, 3, 19, 26, 14, 710, DateTimeKind.Local).AddTicks(6412));
        }
    }
}
