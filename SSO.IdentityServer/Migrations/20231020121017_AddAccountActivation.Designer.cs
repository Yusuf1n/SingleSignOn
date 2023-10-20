﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSO.IdentityServer.DbContexts;

#nullable disable

namespace SSO.IdentityServer.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    [Migration("20231020121017_AddAccountActivation")]
    partial class AddAccountActivation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SSO.IdentityServer.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SecurityCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("SecurityCodeExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Subject")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Active = true,
                            ConcurrencyStamp = "c59bae21-48d8-431c-888f-71f74cc940f3",
                            Email = "david@someprovider.com",
                            Password = "AQAAAAEAACcQAAAAEIi0HEeTvqcxwhA+dR/RKOEIfdGn1VIKy0P+AhKOp5vIdsb80zmPxqbhxllt5AmkKg==",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "d860efca-22d9-47fd-8249-791ba61b07c7",
                            UserName = "David"
                        },
                        new
                        {
                            Id = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Active = true,
                            ConcurrencyStamp = "25121c9b-a6ee-4122-80f6-6a5f5879c1ae",
                            Email = "yusufnaheem1@gmail.com",
                            Password = "AQAAAAEAACcQAAAAEHgXILmaP4pu/Kz8M2cASmfD/XsHykcmTNyFTvQQiwyWaLWjWAlxBH1L5pQfSyRYqw==",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                            UserName = "Yusuf"
                        },
                        new
                        {
                            Id = new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                            Active = true,
                            ConcurrencyStamp = "3edaebcc-780d-4015-acb1-1fbe711f3995",
                            Email = "muhammad@someprovider.com",
                            Password = "AQAAAAEAACcQAAAAEHgXILmaP4pu/Kz8M2cASmfD/XsHykcmTNyFTvQQiwyWaLWjWAlxBH1L5pQfSyRYqw==",
                            SecurityCodeExpirationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "e7ea84c8-b140-4e56-85a8-b0df8b4b4fc6",
                            UserName = "Muhammad"
                        });
                });

            modelBuilder.Entity("SSO.IdentityServer.Entities.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8f2bdfbb-404b-4dbd-9549-5e5ec48d1d70"),
                            ConcurrencyStamp = "5cc699ef-f5dc-4a38-a9e4-79638b16fd4b",
                            Type = "given_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "David"
                        },
                        new
                        {
                            Id = new Guid("c85627c8-e441-4c81-bea9-d10663a18601"),
                            ConcurrencyStamp = "c05a63fd-1721-4d87-98de-a9ff36e20aa5",
                            Type = "family_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Flagg"
                        },
                        new
                        {
                            Id = new Guid("bc300c84-a19a-4277-999c-0570b7fd271f"),
                            ConcurrencyStamp = "c1850d4d-d743-4079-877f-ef07c5eb27e9",
                            Type = "country",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "nl"
                        },
                        new
                        {
                            Id = new Guid("b5e5613f-3d30-4b07-a378-5e7f24286eb8"),
                            ConcurrencyStamp = "67f592cf-1f81-404c-a177-80893b7e5859",
                            Type = "role",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "FreeUser"
                        },
                        new
                        {
                            Id = new Guid("3c8bf238-9f3b-45c5-a2a5-453be2967375"),
                            ConcurrencyStamp = "423db4f1-3079-407f-bbb0-5813d2621dde",
                            Type = "client",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "client1"
                        },
                        new
                        {
                            Id = new Guid("497d39cf-13ea-46e9-88cb-97e5020b4a99"),
                            ConcurrencyStamp = "146a56e6-afd3-4b1e-ad9b-01dc5adca70a",
                            Type = "given_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Yusuf"
                        },
                        new
                        {
                            Id = new Guid("643c56e0-c314-4f00-a42c-fe276ff7f4bc"),
                            ConcurrencyStamp = "32737bff-93c1-4967-81eb-8e25cfbebbdc",
                            Type = "family_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Naheem"
                        },
                        new
                        {
                            Id = new Guid("4e0aac2f-bfdd-4ca1-b424-fd718cee8aff"),
                            ConcurrencyStamp = "fb7ed456-1be2-48e8-85d6-f7dccfe6d67f",
                            Type = "country",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "pk"
                        },
                        new
                        {
                            Id = new Guid("4646e3ca-8c1a-4f11-8dc7-036762e780e3"),
                            ConcurrencyStamp = "dc1afc38-98fc-4a5b-880e-61e60d9a967e",
                            Type = "role",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "PayingUser"
                        },
                        new
                        {
                            Id = new Guid("09b07d9a-4923-4177-b9ec-4e5f6c930de9"),
                            ConcurrencyStamp = "ce5fdc9e-6dda-428c-b28d-540f280f1459",
                            Type = "client",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "client1"
                        },
                        new
                        {
                            Id = new Guid("2362f050-b336-4fcf-ad04-a72e070d4746"),
                            ConcurrencyStamp = "c944dcca-aa44-4125-9675-62bbdc30352a",
                            Type = "given_name",
                            UserId = new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                            Value = "Muhammad"
                        },
                        new
                        {
                            Id = new Guid("6b5cf8ae-075e-4e3d-a412-98625c64d239"),
                            ConcurrencyStamp = "2762d254-0506-4cca-8bb3-ac14bb873bea",
                            Type = "client",
                            UserId = new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                            Value = "client2"
                        },
                        new
                        {
                            Id = new Guid("d8b77d60-ef3a-47dd-987b-1f19732c0e01"),
                            ConcurrencyStamp = "60a6db21-fe29-4db0-9935-0e9b8087d804",
                            Type = "client",
                            UserId = new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                            Value = "clientblazor"
                        });
                });

            modelBuilder.Entity("SSO.IdentityServer.Entities.UserClaim", b =>
                {
                    b.HasOne("SSO.IdentityServer.Entities.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SSO.IdentityServer.Entities.User", b =>
                {
                    b.Navigation("Claims");
                });
#pragma warning restore 612, 618
        }
    }
}