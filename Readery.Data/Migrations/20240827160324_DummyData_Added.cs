using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readery.Data.Migrations
{
    public partial class DummyData_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AddressId", "BirthDate", "FirstName", "LastName", "UserId" },
                values: new object[] { 1, 1, new DateTime(1990, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petur", "Georgiev", new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1") });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Germany" },
                    { 2, "Bulgaria" },
                    { 3, "France" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "AddressId", "Email", "PhoneNumber" },
                values: new object[] { 1, 2, "publisher@gmail.com", "+49 1234 5678" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AuthorId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShippingAddressId", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("cfa97e8d-d92c-487b-91b7-6c3e5e78b571"), 0, null, "8d1f2829-e133-4efb-9a12-b068f31a1be5", "common1@gmail.com", false, false, null, "COMMON1@GMAIL.COM", "COMMON", "AQAAAAEAACcQAAAAELZHGoZxyGZ70pQp+Ph/Y07DEQUO/w5Nnh01OETEKfAAEq2cnaC6QJkCPUHpIc+R+A==", null, false, "38c0893c-364f-4dcb-af36-fa76da7a99b5", null, false, "Common" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AuthorId", "City", "CountryId", "PublisherId", "Street" },
                values: new object[,]
                {
                    { 1, 1, "Blagoevgrad", 2, null, "Geo Milev 15A" },
                    { 2, null, "Frankfurt", 1, 1, "Power 11A" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AddedOn", "AuthorId", "Description", "ImagePath", "IsRemoved", "Language", "PagesCount", "Price", "PublisherId", "Title", "UpdatedOn", "WrittenOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 27, 19, 3, 23, 713, DateTimeKind.Local).AddTicks(6386), 1, "The main character does some pretty amazing stuff and is super amazing", "images/books/book1.webp", false, "bg", 301, 30.00m, 1, "Bulgarian Book1", null, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 8, 27, 19, 3, 23, 713, DateTimeKind.Local).AddTicks(6420), 1, "The main character does some pretty bad stuff and is super evil", "images/books/book2.webp", false, "bg", 280, 27.00m, 1, "Bulgarian Book2", null, new DateTime(2017, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 8, 27, 19, 3, 23, 713, DateTimeKind.Local).AddTicks(6424), 1, "The main character does some pretty shady stuff and is super sneaky", "images/books/book3.webp", false, "bg", 445, 35.00m, 1, "Bulgarian Book3", null, new DateTime(2008, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AuthorId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShippingAddressId", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"), 0, 1, "672f6fa9-51a3-4038-bd39-75296926d650", "author1@gmail.com", false, false, null, "AUTHOR@GMAIL.COM", "AUTHOR", "AQAAAAEAACcQAAAAECPoJ/8UGPKTbx1nMONY2g7qcI7U6tRUd85Vg5IfpxGwVS5XO5sLP3CyXvyX8sxQog==", null, false, "a580162f-1498-4a10-b228-9479271cb79d", null, false, "Author" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cfa97e8d-d92c-487b-91b7-6c3e5e78b571"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
