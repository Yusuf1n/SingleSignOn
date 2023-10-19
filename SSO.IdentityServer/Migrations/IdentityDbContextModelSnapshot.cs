﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSO.IdentityServer.DbContexts;

#nullable disable

namespace SSO.IdentityServer.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    partial class IdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Password")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

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
                            ConcurrencyStamp = "5fea5574-56a5-4b9f-841c-f78b63186956",
                            Password = "AQAAAAEAACcQAAAAEIi0HEeTvqcxwhA+dR/RKOEIfdGn1VIKy0P+AhKOp5vIdsb80zmPxqbhxllt5AmkKg==",
                            Subject = "d860efca-22d9-47fd-8249-791ba61b07c7",
                            UserName = "David"
                        },
                        new
                        {
                            Id = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Active = true,
                            ConcurrencyStamp = "7feebb55-6faf-4e97-8720-5740b3288073",
                            Password = "AQAAAAEAACcQAAAAEHgXILmaP4pu/Kz8M2cASmfD/XsHykcmTNyFTvQQiwyWaLWjWAlxBH1L5pQfSyRYqw==",
                            Subject = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                            UserName = "Yusuf"
                        },
                        new
                        {
                            Id = new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                            Active = true,
                            ConcurrencyStamp = "4376b111-f6a5-4e8b-8ef5-fade4118ed55",
                            Password = "AQAAAAEAACcQAAAAEHgXILmaP4pu/Kz8M2cASmfD/XsHykcmTNyFTvQQiwyWaLWjWAlxBH1L5pQfSyRYqw==",
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
                            Id = new Guid("526ab16a-df31-4d09-b026-140626f50d63"),
                            ConcurrencyStamp = "aa613731-14ca-4ff4-bfa6-b975df180560",
                            Type = "given_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "David"
                        },
                        new
                        {
                            Id = new Guid("7e0fd1b2-1c59-46d7-ba72-19fbd077c67b"),
                            ConcurrencyStamp = "11311d12-6fc7-4eba-9973-4266f8f93884",
                            Type = "family_name",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "Flagg"
                        },
                        new
                        {
                            Id = new Guid("e68c22c5-5957-4b14-8bf7-866f601d1b8b"),
                            ConcurrencyStamp = "1c9ca9ee-e3d0-4ab2-9bd9-a02760ebf902",
                            Type = "country",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "nl"
                        },
                        new
                        {
                            Id = new Guid("df44ea78-baf3-4ea1-bf19-ef266736194b"),
                            ConcurrencyStamp = "17a75ac9-f07e-4ccc-bf8e-151025e3bbe6",
                            Type = "role",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "FreeUser"
                        },
                        new
                        {
                            Id = new Guid("e8bc0c2f-f57f-475a-8aae-ba35ff958b42"),
                            ConcurrencyStamp = "1c1ce199-e88b-4b7e-afe6-9ab99c3e90fd",
                            Type = "client",
                            UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                            Value = "client1"
                        },
                        new
                        {
                            Id = new Guid("913a59a8-56f3-477c-967e-97c9e64aa623"),
                            ConcurrencyStamp = "1866c5b2-2687-4544-ac43-3bdbdf910395",
                            Type = "given_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Yusuf"
                        },
                        new
                        {
                            Id = new Guid("a04ffdee-7f8f-400d-a778-cf868505ba90"),
                            ConcurrencyStamp = "c36059c9-4af9-47f5-8acc-78974707ce03",
                            Type = "family_name",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "Naheem"
                        },
                        new
                        {
                            Id = new Guid("53ae8c47-3c9f-493c-a874-0ef010cb2bf7"),
                            ConcurrencyStamp = "d52d6d94-9cb0-4237-9a78-85aed6585488",
                            Type = "country",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "pk"
                        },
                        new
                        {
                            Id = new Guid("eeb0d180-c6d7-45f4-91e9-35b4fb316d29"),
                            ConcurrencyStamp = "8c7153ec-1e86-4a2c-acdc-c0be3cabedfb",
                            Type = "role",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "PayingUser"
                        },
                        new
                        {
                            Id = new Guid("ab68f6b9-bd6a-43f7-89a7-6b1bf48b5f3a"),
                            ConcurrencyStamp = "25757547-5617-4af9-bbd3-14b26ce3bd4b",
                            Type = "client",
                            UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                            Value = "client1"
                        },
                        new
                        {
                            Id = new Guid("d70eda36-4573-477c-b534-db5dad015e1a"),
                            ConcurrencyStamp = "d783cbf1-c6bd-44ce-9f84-6ded61d4e14b",
                            Type = "given_name",
                            UserId = new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                            Value = "Muhammad"
                        },
                        new
                        {
                            Id = new Guid("31ae204b-99ef-477b-8c1e-062d41dd78d9"),
                            ConcurrencyStamp = "7f560f58-882e-425a-90c0-69443a229a47",
                            Type = "client",
                            UserId = new Guid("5f05b022-764e-48c7-a200-c50e9ff062ea"),
                            Value = "client2"
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
