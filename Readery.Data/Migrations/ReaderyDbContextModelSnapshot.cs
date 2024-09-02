﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Readery.Data;

#nullable disable

namespace Readery.Data.Migrations
{
    [DbContext(typeof(ReaderyDbContext))]
    partial class ReaderyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Readery.Data.Data.Models.Address", b =>
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
                            City = "Blagoevgrad",
                            CountryId = 2,
                            Street = "Geo Milev 15A"
                        },
                        new
                        {
                            Id = 2,
                            City = "Frankfurt",
                            CountryId = 1,
                            PublisherId = 1,
                            Street = "Power 11A"
                        });
                });

            modelBuilder.Entity("Readery.Data.Data.Models.ApplicationRole", b =>
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

            modelBuilder.Entity("Readery.Data.Data.Models.ApplicationUser", b =>
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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShippingAddressId")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId")
                        .IsUnique()
                        .HasFilter("[AuthorId] IS NOT NULL");

                    b.HasIndex("ShippingAddressId")
                        .IsUnique()
                        .HasFilter("[ShippingAddressId] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cfa97e8d-d92c-487b-91b7-6c3e5e78b571"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8d1f2829-e133-4efb-9a12-b068f31a1be5",
                            Email = "common1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "COMMON1@GMAIL.COM",
                            NormalizedUserName = "COMMON",
                            PasswordHash = "AQAAAAEAACcQAAAAELZHGoZxyGZ70pQp+Ph/Y07DEQUO/w5Nnh01OETEKfAAEq2cnaC6QJkCPUHpIc+R+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "38c0893c-364f-4dcb-af36-fa76da7a99b5",
                            TwoFactorEnabled = false,
                            UserName = "Common"
                        },
                        new
                        {
                            Id = new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1"),
                            AccessFailedCount = 0,
                            AuthorId = 1,
                            ConcurrencyStamp = "672f6fa9-51a3-4038-bd39-75296926d650",
                            Email = "author1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "AUTHOR@GMAIL.COM",
                            NormalizedUserName = "AUTHOR",
                            PasswordHash = "AQAAAAEAACcQAAAAECPoJ/8UGPKTbx1nMONY2g7qcI7U6tRUd85Vg5IfpxGwVS5XO5sLP3CyXvyX8sxQog==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a580162f-1498-4a10-b228-9479271cb79d",
                            TwoFactorEnabled = false,
                            UserName = "Author"
                        });
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Author", b =>
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
                            FirstName = "Petur",
                            LastName = "Georgiev",
                            UserId = new Guid("c18fa7b4-63a5-4cb2-a07c-99eaf9134fd1")
                        });
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Book", b =>
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
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

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
                            AddedOn = new DateTime(2024, 8, 27, 19, 3, 23, 713, DateTimeKind.Local).AddTicks(6386),
                            AuthorId = 1,
                            Description = "The main character does some pretty amazing stuff and is super amazing",
                            ImagePath = "images/books/book1.webp",
                            IsRemoved = false,
                            Language = "bg",
                            PagesCount = 301,
                            Price = 30.00m,
                            PublisherId = 1,
                            Title = "Bulgarian Book1",
                            WrittenOn = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AddedOn = new DateTime(2024, 8, 27, 19, 3, 23, 713, DateTimeKind.Local).AddTicks(6420),
                            AuthorId = 1,
                            Description = "The main character does some pretty bad stuff and is super evil",
                            ImagePath = "images/books/book2.webp",
                            IsRemoved = false,
                            Language = "bg",
                            PagesCount = 280,
                            Price = 27.00m,
                            PublisherId = 1,
                            Title = "Bulgarian Book2",
                            WrittenOn = new DateTime(2017, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AddedOn = new DateTime(2024, 8, 27, 19, 3, 23, 713, DateTimeKind.Local).AddTicks(6424),
                            AuthorId = 1,
                            Description = "The main character does some pretty shady stuff and is super sneaky",
                            ImagePath = "images/books/book3.webp",
                            IsRemoved = false,
                            Language = "bg",
                            PagesCount = 445,
                            Price = 35.00m,
                            PublisherId = 1,
                            Title = "Bulgarian Book3",
                            WrittenOn = new DateTime(2008, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Country", b =>
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
                        });
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShippingAddressId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ShippingAddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.OrderBook", b =>
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

            modelBuilder.Entity("Readery.Data.Data.Models.Publisher", b =>
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
                            PhoneNumber = "+49 1234 5678"
                        });
                });

            modelBuilder.Entity("Readery.Data.Data.Models.ShippingAddress", b =>
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

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("ShippingAddresses");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Address", b =>
                {
                    b.HasOne("Readery.Data.Data.Models.Author", "Author")
                        .WithOne("Address")
                        .HasForeignKey("Readery.Data.Data.Models.Address", "AuthorId");

                    b.HasOne("Readery.Data.Data.Models.Country", "Country")
                        .WithMany("Addresses")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Readery.Data.Data.Models.Publisher", "Publisher")
                        .WithOne("Address")
                        .HasForeignKey("Readery.Data.Data.Models.Address", "PublisherId");

                    b.Navigation("Author");

                    b.Navigation("Country");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("Readery.Data.Data.Models.Author", "Author")
                        .WithOne("User")
                        .HasForeignKey("Readery.Data.Data.Models.ApplicationUser", "AuthorId");

                    b.HasOne("Readery.Data.Data.Models.ShippingAddress", "ShippingAddress")
                        .WithOne("User")
                        .HasForeignKey("Readery.Data.Data.Models.ApplicationUser", "ShippingAddressId");

                    b.Navigation("Author");

                    b.Navigation("ShippingAddress");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Book", b =>
                {
                    b.HasOne("Readery.Data.Data.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Readery.Data.Data.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Order", b =>
                {
                    b.HasOne("Readery.Data.Data.Models.ShippingAddress", "ShippingAddress")
                        .WithMany("Orders")
                        .HasForeignKey("ShippingAddressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Readery.Data.Data.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ShippingAddress");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.OrderBook", b =>
                {
                    b.HasOne("Readery.Data.Data.Models.Book", "Book")
                        .WithMany("OrderBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Readery.Data.Data.Models.Order", "Order")
                        .WithMany("OrderBooks")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.ShippingAddress", b =>
                {
                    b.HasOne("Readery.Data.Data.Models.Country", "Country")
                        .WithMany("ShippingAddresses")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Author", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Book", b =>
                {
                    b.Navigation("OrderBooks");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Country", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("ShippingAddresses");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Order", b =>
                {
                    b.Navigation("OrderBooks");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.Publisher", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Books");
                });

            modelBuilder.Entity("Readery.Data.Data.Models.ShippingAddress", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("User")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
