using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readery.Domain.Migrations
{
    public partial class AppUserProperty_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae48ab8d-57d2-4c78-a0b3-686f967a14e8"));

            migrationBuilder.AddColumn<bool>(
                name: "RememberDeliveryInfo",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6a05ce3-9966-451e-afaa-eeed165c7741"));

            migrationBuilder.DropColumn(
                name: "RememberDeliveryInfo",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 9, 11, 15, 5, 3, 743, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 9, 11, 15, 5, 3, 743, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 9, 11, 15, 5, 3, 743, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 9, 11, 15, 5, 3, 743, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "293e7427-0fe2-437c-bba3-8d172d7fdc70", "AQAAAAEAACcQAAAAEFVNezd9aWe5/nFya6p/Mw79mCcPt5ZjjWmJokUCSu0+409m3PMGBytwDxwR1bDTrg==", "fa80be80-e21e-4d7d-b6a5-44d19f650916" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AuthorId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ae48ab8d-57d2-4c78-a0b3-686f967a14e8"), 0, null, "a2f402e3-d148-483e-b2df-f62be8efbe92", "common1@gmail.com", false, false, null, "COMMON1@GMAIL.COM", "COMMON", "AQAAAAEAACcQAAAAEN9eIBvCfdtHzNBll0drf84Pdj4WdSmUcfN2WlybV+RAWGT/Np0y45gZdKE6/yG7mg==", null, false, "39a88a36-ccb2-42fb-a49f-b35b5285b417", false, "Common" });
        }
    }
}
