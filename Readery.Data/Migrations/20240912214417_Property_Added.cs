using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readery.Domain.Migrations
{
    public partial class Property_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6a05ce3-9966-451e-afaa-eeed165c7741"));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 9, 13, 0, 44, 16, 271, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 9, 13, 0, 44, 16, 271, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 9, 13, 0, 44, 16, 271, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 9, 13, 0, 44, 16, 271, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "659ab3c5-55fd-453c-bfd0-0104f41ba1f2", "AQAAAAEAACcQAAAAEK9kdCfDrcFnEW7HEV/VxeWf3nzxsrCy9SzPbOP0JTjzXsou8iIAbOk6jthfqHA/4Q==", "7fc6231c-592c-4531-976c-ac8152c878d7" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AuthorId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RememberDeliveryInfo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e891fc9a-c15a-4292-bdd1-d19a4fcde9e1"), 0, null, "cf6d0fa6-647a-485a-9635-40dc0b37cf20", "common1@gmail.com", false, false, null, "COMMON1@GMAIL.COM", "COMMON", "AQAAAAEAACcQAAAAEN7NSKYUdBIxIwrE51Jy3YW5WK0HKMcYFgCPcSlobn9oga/Od0mKYA3EyBl3DtsCxQ==", null, false, false, "b9fe52a2-819a-4ecc-aced-02f41aebb257", false, "Common" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e891fc9a-c15a-4292-bdd1-d19a4fcde9e1"));

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 9, 12, 17, 22, 52, 394, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 9, 12, 17, 22, 52, 394, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 9, 12, 17, 22, 52, 394, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 9, 12, 17, 22, 52, 394, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6e4c91d-8e7d-4d65-ad69-8ebe7a1fa9ef", "AQAAAAEAACcQAAAAED5fRlcs/qNOzBZn3ROJyBhcUjUrwM4PmVjIjjQCfdU7iw3b6gpOhc7xwp5g2DmCFA==", "4fb2e880-a521-463d-8329-3df87dd788a0" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AuthorId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RememberDeliveryInfo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b6a05ce3-9966-451e-afaa-eeed165c7741"), 0, null, "f5d982d9-faa4-48ac-9e8b-dd4544cc4171", "common1@gmail.com", false, false, null, "COMMON1@GMAIL.COM", "COMMON", "AQAAAAEAACcQAAAAEObStTby12A1+hVc6LAvPLY0iGZYiqEB/QMlYYV5nNHzLeDx78HrjKK+Gfajf2n3lw==", null, false, false, "7ea98a12-1287-4b96-8838-cf9ff1e3d93b", false, "Common" });
        }
    }
}
