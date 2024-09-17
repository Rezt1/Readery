using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readery.Domain.Migrations
{
    public partial class MoreBooks_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 9, 16, 23, 27, 16, 859, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "WrittenOn" },
                values: new object[] { new DateTime(2024, 9, 16, 23, 27, 16, 859, DateTimeKind.Local).AddTicks(1262), new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "WrittenOn" },
                values: new object[] { new DateTime(2024, 9, 16, 23, 27, 16, 859, DateTimeKind.Local).AddTicks(1265), new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "WrittenOn" },
                values: new object[] { new DateTime(2024, 9, 16, 23, 27, 16, 859, DateTimeKind.Local).AddTicks(1267), new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AddedOn", "AuthorId", "Description", "ImagePath", "IsRemoved", "Language", "PagesCount", "Price", "PublisherId", "Title", "UpdatedOn", "WrittenOn" },
                values: new object[,]
                {
                    { 5, new DateTime(2024, 9, 16, 23, 27, 16, 859, DateTimeKind.Local).AddTicks(1269), 1, "Ayanokouji’s relationship with Karuizawa deepens, while the aftershock of his perfect mathematics score ripples through the school. Horikita asks to join the student council, and is accepted by Nagumo. And summer vacation brings with it no rest, but another special exam–a reprise of the earlier deserted island test. Except this time, it’ll be a battle royale with all three grade levels duking it out against each other!", "images/books/cote-y2-2.jpg", false, "en", 330, 33.50m, 1, "Classroom of the elite: Year 2 (Light Novel) Vol. 2", null, new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2024, 9, 16, 23, 27, 16, 859, DateTimeKind.Local).AddTicks(1271), 1, "The special exam on an uninhabited island has begun! For two weeks, students will do their best to visit checkpoints and complete challenges to gain points with their groups. Well, except for Ayanokouji, who has opted to tackle this exam on his own… or has he? Nanase, a first-year student from Class D, breaks off from her own group and asks to tag along with him, but there doesn’t seem to be anything in it for her. Just what is this under-classman’s goal?", "images/books/cote-y2-3.jpg", false, "en", 338, 35.10m, 1, "Classroom of the elite: Year 2 (Light Novel) Vol. 3", null, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2024, 9, 16, 23, 27, 16, 859, DateTimeKind.Local).AddTicks(1274), 1, "Class D has conquered the midterms, but their celebration is cut short when three Class C students falsely accuse Sudou of assaulting them! With their friend facing expulsion, and the class’s points on the line, Ayanokouji, Horikita, and Kikyou must team up to gather evidence to prove his innocence.", "images/books/cote2.jpg", false, "en", 352, 37.20m, 1, "Classroom of the elite (Light Novel) Vol. 2", null, new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2024, 9, 16, 23, 27, 16, 859, DateTimeKind.Local).AddTicks(1276), 1, "School may be on vacation, but the scheming never stops! Christmas draws near, and Karuizawa and Satou compete for Ayanokouji’s affections while new student council president Nagumo makes his first sinister moves. Don’t miss this bonus volume of short stories, covering the events of a winter break that will decide the balance of power in the upcoming third semester!", "images/books/cote7-5.jpg", false, "en", 352, 32.60m, 1, "Classroom of the elite (Light Novel) Vol. 7.5", null, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2024, 9, 16, 23, 27, 16, 859, DateTimeKind.Local).AddTicks(1279), 1, "Sakayanagi puts her plan to crush Ichinose into motion, spreading rumors of her alleged war criminal history through the school like wildfire. With Class B at a loss, and Ichinose herself uncharacteristically reluctant to fight back, can Ayanokouji step in to save her reputation? Meanwhile, Kushida makes contact with student council president Nagumo in what might prove to be a very dangerous alliance, indeed.", "images/books/cote9.jpg", false, "en", 342, 33.20m, 1, "Classroom of the elite (Light Novel) Vol. 9", null, new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2024, 9, 16, 23, 27, 16, 859, DateTimeKind.Local).AddTicks(1281), 1, "It's spring, and for the first time in the school’s history, no one has been expelled after the third semester exams. As a result, the Advanced Nurturing High School sets a cruel test—each class must choose one of their own members to be expelled. Chaos consumes the first-years as Hirata tries and fails to keep the class from turning on each other, Ichinose strikes a costly bargain with Nagumo, and Ryuuen’s classmates seem ready to throw him to the wolves. Can Class C make it out of this unscathed—or will they be undone by traitors within?", "images/books/cote10.jpg", false, "en", 383, 39.20m, 1, "Classroom of the elite (Light Novel) Vol. 10", null, new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fc314bd-872a-43b0-84fb-ecfeb2f55cdb", "AQAAAAEAACcQAAAAECftGBiRWTbma/zdORhAptz6F9UDkrIR5V5VtVFbrau8Si08P5kRA8zMKE0ozHEYOQ==", "cbe9e606-f350-4e42-befe-8d18922e072a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);


            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

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
                columns: new[] { "AddedOn", "WrittenOn" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 44, 16, 271, DateTimeKind.Local).AddTicks(3409), new DateTime(2017, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "WrittenOn" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 44, 16, 271, DateTimeKind.Local).AddTicks(3420), new DateTime(2008, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "WrittenOn" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 44, 16, 271, DateTimeKind.Local).AddTicks(3425), new DateTime(2008, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "659ab3c5-55fd-453c-bfd0-0104f41ba1f2", "AQAAAAEAACcQAAAAEK9kdCfDrcFnEW7HEV/VxeWf3nzxsrCy9SzPbOP0JTjzXsou8iIAbOk6jthfqHA/4Q==", "7fc6231c-592c-4531-976c-ac8152c878d7" });
        }
    }
}
