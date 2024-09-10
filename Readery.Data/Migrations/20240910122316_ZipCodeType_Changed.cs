using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readery.Domain.Migrations
{
    public partial class ZipCodeType_Changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42735243-89f3-4e51-86ad-d8e466381ada"));

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "ShippingAddresses",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 9, 10, 15, 23, 16, 202, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 9, 10, 15, 23, 16, 202, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 9, 10, 15, 23, 16, 202, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 9, 10, 15, 23, 16, 202, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4c18e2b-0a7a-40ac-a722-49c207f459c4", "AQAAAAEAACcQAAAAEKtR4FmlhUJk7FPSM3qwEskVUADxmFHJTCVr/peKXsZ46MfdzAJ0dN3+r3MVH6DQNQ==", "0c7021d4-33c7-455f-93cc-47dd5a65705b" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AuthorId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("97d6d163-a110-4cea-be40-93a6903a604e"), 0, null, "fcfe0f03-6cb5-4667-8ab5-0a65a45b26c3", "common1@gmail.com", false, false, null, "COMMON1@GMAIL.COM", "COMMON", "AQAAAAEAACcQAAAAEKOY3QYH7yTDJp2bHwkOf9f+eHa+xvst/0Cr8QZMzJGgw/wxFg2K/JXcm2DF00acow==", null, false, "6a3e6d58-d639-449a-81d1-7ca27eaecf02", false, "Common" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97d6d163-a110-4cea-be40-93a6903a604e"));

            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "ShippingAddresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 9, 8, 22, 23, 31, 615, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 9, 8, 22, 23, 31, 615, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 9, 8, 22, 23, 31, 615, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 9, 8, 22, 23, 31, 615, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "840cff2b-00d3-4679-8a5d-4343849d2383", "AQAAAAEAACcQAAAAEMduhVKTNdt0h5bDhsIwgbNmXFkT/BfhNZQ5FfF/U0NnTBRApA0UFRzquWU4A9Kqbg==", "a71e40e8-0217-4a2f-8a67-fdce9dda8e98" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AuthorId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("42735243-89f3-4e51-86ad-d8e466381ada"), 0, null, "696b9f66-01b0-459e-9b95-931b61961c2a", "common1@gmail.com", false, false, null, "COMMON1@GMAIL.COM", "COMMON", "AQAAAAEAACcQAAAAEFKU/8wTkQ/GGI1zCsOFIZrX+yTieVZVwSAucmQcAap9L6RnGnwLb2yNl1dSJN1HNg==", null, false, "b1d69c93-e4d6-434c-8f21-d903829eba9f", false, "Common" });
        }
    }
}
