﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Readery.Domain.Data;

#nullable disable

namespace Readery.Domain.Migrations
{
    [DbContext(typeof(ReaderyDbContext))]
    [Migration("20240912142252_AppUserProperty_Added")]
    partial class AppUserProperty_Added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int?>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId")
                        .IsUnique()
                        .HasFilter("[AuthorId] IS NOT NULL");

                    b.HasIndex("CountryId");

                    b.HasIndex("PublisherId")
                        .IsUnique()
                        .HasFilter("[PublisherId] IS NOT NULL");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            City = "Tokyo",
                            CountryId = 4,
                            Street = "Dragon Path 5"
                        },
                        new
                        {
                            Id = 2,
                            City = "Tokyo",
                            CountryId = 4,
                            PublisherId = 1,
                            Street = "Snake Street 18"
                        });
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("RememberDeliveryInfo")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId")
                        .IsUnique()
                        .HasFilter("[AuthorId] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b6a05ce3-9966-451e-afaa-eeed165c7741"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f5d982d9-faa4-48ac-9e8b-dd4544cc4171",
                            Email = "common1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "COMMON1@GMAIL.COM",
                            NormalizedUserName = "COMMON",
                            PasswordHash = "AQAAAAEAACcQAAAAEObStTby12A1+hVc6LAvPLY0iGZYiqEB/QMlYYV5nNHzLeDx78HrjKK+Gfajf2n3lw==",
                            PhoneNumberConfirmed = false,
                            RememberDeliveryInfo = false,
                            SecurityStamp = "7ea98a12-1287-4b96-8838-cf9ff1e3d93b",
                            TwoFactorEnabled = false,
                            UserName = "Common"
                        },
                        new
                        {
                            Id = new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"),
                            AccessFailedCount = 0,
                            AuthorId = 1,
                            ConcurrencyStamp = "e6e4c91d-8e7d-4d65-ad69-8ebe7a1fa9ef",
                            Email = "author1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "AUTHOR@GMAIL.COM",
                            NormalizedUserName = "AUTHOR",
                            PasswordHash = "AQAAAAEAACcQAAAAED5fRlcs/qNOzBZn3ROJyBhcUjUrwM4PmVjIjjQCfdU7iw3b6gpOhc7xwp5g2DmCFA==",
                            PhoneNumberConfirmed = false,
                            RememberDeliveryInfo = false,
                            SecurityStamp = "4fb2e880-a521-463d-8329-3df87dd788a0",
                            TwoFactorEnabled = false,
                            UserName = "Author"
                        });
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            BirthDate = new DateTime(1990, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Syougo",
                            LastName = "Kinugasa",
                            UserId = new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1")
                        });
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("PagesCount")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WrittenOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddedOn = new DateTime(2024, 9, 12, 17, 22, 52, 394, DateTimeKind.Local).AddTicks(3985),
                            AuthorId = 1,
                            Description = "Students of the prestigious Tokyo Metropolitan Advanced Nurturing High School are given remarkable freedom—if they can win, barter, or save enough points to work their way up the ranks! Ayanokouji Kiyotaka has landed at the bottom in the scorned Class D, where he meets Horikita Suzune, who’s determined to rise up the ladder to Class A. Can they beat the system in a school where cutthroat competition is the name of the game?",
                            ImagePath = "images/books/cote1.jpg",
                            IsRemoved = false,
                            Language = "en",
                            PagesCount = 301,
                            Price = 30.00m,
                            PublisherId = 1,
                            Title = "Classroom of the elite (Light Novel) Vol. 1",
                            WrittenOn = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AddedOn = new DateTime(2024, 9, 12, 17, 22, 52, 394, DateTimeKind.Local).AddTicks(4022),
                            AuthorId = 1,
                            Description = "Having survived their final exams, Ayanokouji and the others are looking forward to an idyllic school-sponsored summer vacation aboard a cruise ship. But nothing is ever quite as it seems with the Tokyo Advanced Nurturing High School, and the cruise turns out to be the cover for a series of special tests! What grueling new challenges await them out at sea?!",
                            ImagePath = "images/books/cote3.jpg",
                            IsRemoved = false,
                            Language = "en",
                            PagesCount = 280,
                            Price = 27.00m,
                            PublisherId = 1,
                            Title = "Classroom of the elite (Light Novel) Vol. 3",
                            WrittenOn = new DateTime(2017, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AddedOn = new DateTime(2024, 9, 12, 17, 22, 52, 394, DateTimeKind.Local).AddTicks(4033),
                            AuthorId = 1,
                            Description = "There’s upheaval in the air as another special exam approaches and Nagumo officially replaces Horikita Manabu as student council president. Meanwhile, Ryuuen is out for blood, and he’s set his sights on Horikita Suzune as the next possible candidate for Class D’s mysterious mastermind!",
                            ImagePath = "images/books/cote6.jpg",
                            IsRemoved = false,
                            Language = "en",
                            PagesCount = 445,
                            Price = 35.00m,
                            PublisherId = 1,
                            Title = "Classroom of the elite (Light Novel) Vol. 6",
                            WrittenOn = new DateTime(2008, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            AddedOn = new DateTime(2024, 9, 12, 17, 22, 52, 394, DateTimeKind.Local).AddTicks(4037),
                            AuthorId = 1,
                            Description = "The third semester kicks off in high gear with a special boot camp deep in the mountains. Forcibly separated into groups along grade and gender lines, the first, second and third years alike must work together to survive the rugged terrain. Even worse? The leader of the group that comes in last will be expelled. Can Class D make it back to campus intact, or is this where they finally say goodbye to one of their own?",
                            ImagePath = "images/books/cote8.jpg",
                            IsRemoved = false,
                            Language = "en",
                            PagesCount = 415,
                            Price = 35.50m,
                            PublisherId = 1,
                            Title = "Classroom of the elite (Light Novel) Vol. 8",
                            WrittenOn = new DateTime(2008, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bulgaria"
                        },
                        new
                        {
                            Id = 3,
                            Name = "France"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Japan"
                        });
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.DeliveryInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("UserId");

                    b.ToTable("DeliveryInformation");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DeliveryInformationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryInformationId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.OrderBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderBooks");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 2,
                            Email = "publisher@gmail.com",
                            Name = "Seven Seas",
                            PhoneNumber = "+81 1234 5678"
                        });
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Address", b =>
                {
                    b.HasOne("Readery.Domain.Data.Models.Author", "Author")
                        .WithOne("Address")
                        .HasForeignKey("Readery.Domain.Data.Models.Address", "AuthorId");

                    b.HasOne("Readery.Domain.Data.Models.Country", "Country")
                        .WithMany("Addresses")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Readery.Domain.Data.Models.Publisher", "Publisher")
                        .WithOne("Address")
                        .HasForeignKey("Readery.Domain.Data.Models.Address", "PublisherId");

                    b.Navigation("Author");

                    b.Navigation("Country");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("Readery.Domain.Data.Models.Author", "Author")
                        .WithOne("User")
                        .HasForeignKey("Readery.Domain.Data.Models.ApplicationUser", "AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Book", b =>
                {
                    b.HasOne("Readery.Domain.Data.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Readery.Domain.Data.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.DeliveryInformation", b =>
                {
                    b.HasOne("Readery.Domain.Data.Models.Country", "Country")
                        .WithMany("DeliveryInformation")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Readery.Domain.Data.Models.ApplicationUser", "User")
                        .WithMany("DeliveryInformation")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Order", b =>
                {
                    b.HasOne("Readery.Domain.Data.Models.DeliveryInformation", "DeliveryInformation")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryInformationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Readery.Domain.Data.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DeliveryInformation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.OrderBook", b =>
                {
                    b.HasOne("Readery.Domain.Data.Models.Book", "Book")
                        .WithMany("OrderBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Readery.Domain.Data.Models.Order", "Order")
                        .WithMany("OrderBooks")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("DeliveryInformation");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Author", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Book", b =>
                {
                    b.Navigation("OrderBooks");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Country", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("DeliveryInformation");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.DeliveryInformation", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Order", b =>
                {
                    b.Navigation("OrderBooks");
                });

            modelBuilder.Entity("Readery.Domain.Data.Models.Publisher", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
