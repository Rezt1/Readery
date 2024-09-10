using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readery.Domain.Migrations
{
    public partial class AddiotionalProperties_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_PersonalDeliveryInformation_PersonalDeliveryInformationId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_ShippingAddresses_ShippingAddressId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PersonalDeliveryInformationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ShippingAddressId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0399a1d3-8614-4cea-88ad-dda9b9977a3d"));

            migrationBuilder.DropColumn(
                name: "PersonalDeliveryInformationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ShippingAddressId",
                table: "Users");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ShippingAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "ShippingAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PersonalDeliveryInformation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "PersonalDeliveryInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalDeliveryInformationId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddresses_UserId",
                table: "ShippingAddresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDeliveryInformation_UserId",
                table: "PersonalDeliveryInformation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PersonalDeliveryInformationId",
                table: "Orders",
                column: "PersonalDeliveryInformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PersonalDeliveryInformation_PersonalDeliveryInformationId",
                table: "Orders",
                column: "PersonalDeliveryInformationId",
                principalTable: "PersonalDeliveryInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDeliveryInformation_Users_UserId",
                table: "PersonalDeliveryInformation",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingAddresses_Users_UserId",
                table: "ShippingAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PersonalDeliveryInformation_PersonalDeliveryInformationId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDeliveryInformation_Users_UserId",
                table: "PersonalDeliveryInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingAddresses_Users_UserId",
                table: "ShippingAddresses");

            migrationBuilder.DropIndex(
                name: "IX_ShippingAddresses_UserId",
                table: "ShippingAddresses");

            migrationBuilder.DropIndex(
                name: "IX_PersonalDeliveryInformation_UserId",
                table: "PersonalDeliveryInformation");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PersonalDeliveryInformationId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42735243-89f3-4e51-86ad-d8e466381ada"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PersonalDeliveryInformation");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "PersonalDeliveryInformation");

            migrationBuilder.DropColumn(
                name: "PersonalDeliveryInformationId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "PersonalDeliveryInformationId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShippingAddressId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 9, 8, 17, 37, 16, 567, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 9, 8, 17, 37, 16, 567, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 9, 8, 17, 37, 16, 567, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 9, 8, 17, 37, 16, 567, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e2a10ec-e269-4738-b959-d2f6568ec9d8", "AQAAAAEAACcQAAAAEBfsk36YypdNKeXmOvsNEikKUmUAQAAvsE4ifjRuHUTCXzbfJx8i/wmd9R1C01pMsQ==", "56d8e16b-cf99-4f48-9083-54c4d7612957" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AuthorId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalDeliveryInformationId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShippingAddressId", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0399a1d3-8614-4cea-88ad-dda9b9977a3d"), 0, null, "7ddb1669-3d71-4036-becc-7a1eaeddd593", "common1@gmail.com", false, false, null, "COMMON1@GMAIL.COM", "COMMON", "AQAAAAEAACcQAAAAEBy82bjJzIddkxoWI7280ZHBC7SesiFIf7nleQV+7769hz2uKA85gk5dDGDSon/jYA==", null, null, false, "474ff4f2-8593-4778-b752-f0dc481634e9", null, false, "Common" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonalDeliveryInformationId",
                table: "Users",
                column: "PersonalDeliveryInformationId",
                unique: true,
                filter: "[PersonalDeliveryInformationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ShippingAddressId",
                table: "Users",
                column: "ShippingAddressId",
                unique: true,
                filter: "[ShippingAddressId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PersonalDeliveryInformation_PersonalDeliveryInformationId",
                table: "Users",
                column: "PersonalDeliveryInformationId",
                principalTable: "PersonalDeliveryInformation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ShippingAddresses_ShippingAddressId",
                table: "Users",
                column: "ShippingAddressId",
                principalTable: "ShippingAddresses",
                principalColumn: "Id");
        }
    }
}
