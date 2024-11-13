using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readery.Domain.Migrations
{
    public partial class Database_Created : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RememberDeliveryInfo = table.Column<bool>(type: "bit", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    PublisherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Addresses_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PagesCount = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    WrittenOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeliveryInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryInformation_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryInformation_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeliveryInformationId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_DeliveryInformation_DeliveryInformationId",
                        column: x => x.DeliveryInformationId,
                        principalTable: "DeliveryInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderBooks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AddressId", "BirthDate", "FirstName", "LastName", "UserId" },
                values: new object[] { 1, 1, new DateTime(1990, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Syougo", "Kinugasa", new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1") });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Germany" },
                    { 2, "Bulgaria" },
                    { 3, "France" },
                    { 4, "Japan" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "AddressId", "Email", "Name", "PhoneNumber" },
                values: new object[] { 1, 2, "publisher@gmail.com", "Seven Seas", "+81 1234 5678" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("7e5291f4-1483-418d-92d2-7d35d9b6a7b0"), "c7691ed8-80d9-4669-91a8-1db59fbb249d", "Author", "AUTHOR" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("7e5291f4-1483-418d-92d2-7d35d9b6a7b0"), new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AuthorId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RememberDeliveryInfo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b0c2414c-071c-436f-b5de-1023739d90be"), 0, null, "c932491a-2c85-4bf9-8bed-e53bcb420c5c", "common1@gmail.com", false, false, null, "COMMON1@GMAIL.COM", "COMMON", "AQAAAAEAACcQAAAAEC6g4b9sEUbBSIqjDRCFY1iQ8pXFreGqKWmssDqHOd/ce8mHrKGtzBRNUWRSol237g==", null, false, false, "89ede71f-126e-4c95-8ac0-83184c71aa3e", false, "Common" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AuthorId", "City", "CountryId", "PublisherId", "Street" },
                values: new object[,]
                {
                    { 1, 1, "Tokyo", 4, null, "Dragon Path 5" },
                    { 2, null, "Tokyo", 4, 1, "Snake Street 18" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AddedOn", "AuthorId", "Description", "ImagePath", "IsRemoved", "Language", "PagesCount", "Price", "PublisherId", "Title", "UpdatedOn", "WrittenOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 12, 21, 17, 32, 356, DateTimeKind.Local).AddTicks(8502), 1, "Students of the prestigious Tokyo Metropolitan Advanced Nurturing High School are given remarkable freedom—if they can win, barter, or save enough points to work their way up the ranks! Ayanokouji Kiyotaka has landed at the bottom in the scorned Class D, where he meets Horikita Suzune, who’s determined to rise up the ladder to Class A. Can they beat the system in a school where cutthroat competition is the name of the game?", "images/books/cote1.jpg", false, "en", 301, 30.00m, 1, "Classroom of the elite (Light Novel) Vol. 1", null, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 11, 12, 21, 17, 32, 356, DateTimeKind.Local).AddTicks(8534), 1, "Having survived their final exams, Ayanokouji and the others are looking forward to an idyllic school-sponsored summer vacation aboard a cruise ship. But nothing is ever quite as it seems with the Tokyo Advanced Nurturing High School, and the cruise turns out to be the cover for a series of special tests! What grueling new challenges await them out at sea?!", "images/books/cote3.jpg", false, "en", 280, 27.00m, 1, "Classroom of the elite (Light Novel) Vol. 3", null, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 11, 12, 21, 17, 32, 356, DateTimeKind.Local).AddTicks(8537), 1, "There’s upheaval in the air as another special exam approaches and Nagumo officially replaces Horikita Manabu as student council president. Meanwhile, Ryuuen is out for blood, and he’s set his sights on Horikita Suzune as the next possible candidate for Class D’s mysterious mastermind!", "images/books/cote6.jpg", false, "en", 445, 35.00m, 1, "Classroom of the elite (Light Novel) Vol. 6", null, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 11, 12, 21, 17, 32, 356, DateTimeKind.Local).AddTicks(8540), 1, "The third semester kicks off in high gear with a special boot camp deep in the mountains. Forcibly separated into groups along grade and gender lines, the first, second and third years alike must work together to survive the rugged terrain. Even worse? The leader of the group that comes in last will be expelled. Can Class D make it back to campus intact, or is this where they finally say goodbye to one of their own?", "images/books/cote8.jpg", false, "en", 415, 35.50m, 1, "Classroom of the elite (Light Novel) Vol. 8", null, new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 11, 12, 21, 17, 32, 356, DateTimeKind.Local).AddTicks(8543), 1, "Ayanokouji’s relationship with Karuizawa deepens, while the aftershock of his perfect mathematics score ripples through the school. Horikita asks to join the student council, and is accepted by Nagumo. And summer vacation brings with it no rest, but another special exam–a reprise of the earlier deserted island test. Except this time, it’ll be a battle royale with all three grade levels duking it out against each other!", "images/books/cote-y2-2.jpg", false, "en", 330, 33.50m, 1, "Classroom of the elite: Year 2 (Light Novel) Vol. 2", null, new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2024, 11, 12, 21, 17, 32, 356, DateTimeKind.Local).AddTicks(8545), 1, "The special exam on an uninhabited island has begun! For two weeks, students will do their best to visit checkpoints and complete challenges to gain points with their groups. Well, except for Ayanokouji, who has opted to tackle this exam on his own… or has he? Nanase, a first-year student from Class D, breaks off from her own group and asks to tag along with him, but there doesn’t seem to be anything in it for her. Just what is this under-classman’s goal?", "images/books/cote-y2-3.jpg", false, "en", 338, 35.10m, 1, "Classroom of the elite: Year 2 (Light Novel) Vol. 3", null, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2024, 11, 12, 21, 17, 32, 356, DateTimeKind.Local).AddTicks(8554), 1, "Class D has conquered the midterms, but their celebration is cut short when three Class C students falsely accuse Sudou of assaulting them! With their friend facing expulsion, and the class’s points on the line, Ayanokouji, Horikita, and Kikyou must team up to gather evidence to prove his innocence.", "images/books/cote2.jpg", false, "en", 352, 37.20m, 1, "Classroom of the elite (Light Novel) Vol. 2", null, new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2024, 11, 12, 21, 17, 32, 356, DateTimeKind.Local).AddTicks(8557), 1, "School may be on vacation, but the scheming never stops! Christmas draws near, and Karuizawa and Satou compete for Ayanokouji’s affections while new student council president Nagumo makes his first sinister moves. Don’t miss this bonus volume of short stories, covering the events of a winter break that will decide the balance of power in the upcoming third semester!", "images/books/cote7-5.jpg", false, "en", 352, 32.60m, 1, "Classroom of the elite (Light Novel) Vol. 7.5", null, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2024, 11, 12, 21, 17, 32, 356, DateTimeKind.Local).AddTicks(8559), 1, "Sakayanagi puts her plan to crush Ichinose into motion, spreading rumors of her alleged war criminal history through the school like wildfire. With Class B at a loss, and Ichinose herself uncharacteristically reluctant to fight back, can Ayanokouji step in to save her reputation? Meanwhile, Kushida makes contact with student council president Nagumo in what might prove to be a very dangerous alliance, indeed.", "images/books/cote9.jpg", false, "en", 342, 33.20m, 1, "Classroom of the elite (Light Novel) Vol. 9", null, new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2024, 11, 12, 21, 17, 32, 356, DateTimeKind.Local).AddTicks(8573), 1, "It's spring, and for the first time in the school’s history, no one has been expelled after the third semester exams. As a result, the Advanced Nurturing High School sets a cruel test—each class must choose one of their own members to be expelled. Chaos consumes the first-years as Hirata tries and fails to keep the class from turning on each other, Ichinose strikes a costly bargain with Nagumo, and Ryuuen’s classmates seem ready to throw him to the wolves. Can Class C make it out of this unscathed—or will they be undone by traitors within?", "images/books/cote10.jpg", false, "en", 383, 39.20m, 1, "Classroom of the elite (Light Novel) Vol. 10", null, new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AuthorId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RememberDeliveryInfo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"), 0, 1, "0b3eaab2-7510-4832-8cf0-5d4753bf0147", "author1@gmail.com", false, false, null, "AUTHOR@GMAIL.COM", "AUTHOR", "AQAAAAEAACcQAAAAEM7WDFMxzAeFnkkhiEacdci44NpUKV2x9hnkpa7m1RsQTYOqp8ty20e8A1jULUmjzA==", null, false, false, "939064c0-cd3b-4c2a-a879-91398287029a", false, "Author" });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AuthorId",
                table: "Addresses",
                column: "AuthorId",
                unique: true,
                filter: "[AuthorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PublisherId",
                table: "Addresses",
                column: "PublisherId",
                unique: true,
                filter: "[PublisherId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryInformation_CountryId",
                table: "DeliveryInformation",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryInformation_UserId",
                table: "DeliveryInformation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBooks_BookId",
                table: "OrderBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBooks_OrderId",
                table: "OrderBooks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryInformationId",
                table: "Orders",
                column: "DeliveryInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AuthorId",
                table: "Users",
                column: "AuthorId",
                unique: true,
                filter: "[AuthorId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "OrderBooks");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "DeliveryInformation");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
