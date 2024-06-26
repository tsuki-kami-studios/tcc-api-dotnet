﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCC.API.Data;

#nullable disable

namespace TCC.API.Migrations
{
    [DbContext(typeof(TccDbContext))]
    [Migration("20240516090526_addedPersonalKeyToToken")]
    partial class addedPersonalKeyToToken
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("TCC.API.Models.data.Address", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<ulong>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Complement")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("longtext");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Reference")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UpdatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("TCC.API.Models.data.Document", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<ulong>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("DriverId")
                        .HasColumnType("bigint unsigned");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UpdatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("VehicleId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("TCC.API.Models.data.Driver", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<ulong>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong?>("DocumentId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UpdatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong?>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("TCC.API.Models.data.Settings", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<ulong>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UpdatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("TCC.API.Models.data.TravelEntry", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<ulong>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<ulong>("DestinationId")
                        .HasColumnType("bigint unsigned");

                    b.Property<double>("Distance")
                        .HasColumnType("double");

                    b.Property<ulong>("DocumentId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("DriverId")
                        .HasColumnType("bigint unsigned");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<ulong>("OriginId")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UpdatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("VehicleId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("DocumentId");

                    b.HasIndex("DriverId");

                    b.HasIndex("OriginId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleId");

                    b.ToTable("TravelEntries");
                });

            modelBuilder.Entity("TCC.API.Models.data.Vehicle", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<ulong>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<ulong?>("DocumentId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UpdatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("TCC.API.models.authentication.Role", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<ulong>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UpdatedBy")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1ul,
                            CreatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 844, DateTimeKind.Local).AddTicks(1190),
                            CreatedBy = 0ul,
                            IsDeleted = false,
                            Name = "Guest",
                            UpdatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(2497),
                            UpdatedBy = 0ul
                        },
                        new
                        {
                            Id = 10ul,
                            CreatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3355),
                            CreatedBy = 0ul,
                            IsDeleted = false,
                            Name = "User",
                            UpdatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3362),
                            UpdatedBy = 0ul
                        },
                        new
                        {
                            Id = 20ul,
                            CreatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3365),
                            CreatedBy = 0ul,
                            IsDeleted = false,
                            Name = "Super-User",
                            UpdatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3366),
                            UpdatedBy = 0ul
                        },
                        new
                        {
                            Id = 100ul,
                            CreatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3369),
                            CreatedBy = 0ul,
                            IsDeleted = false,
                            Name = "Moderator",
                            UpdatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3370),
                            UpdatedBy = 0ul
                        },
                        new
                        {
                            Id = 1000ul,
                            CreatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3372),
                            CreatedBy = 0ul,
                            IsDeleted = false,
                            Name = "Admin",
                            UpdatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3373),
                            UpdatedBy = 0ul
                        },
                        new
                        {
                            Id = 1001ul,
                            CreatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3375),
                            CreatedBy = 0ul,
                            IsDeleted = false,
                            Name = "App-Admin",
                            UpdatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3376),
                            UpdatedBy = 0ul
                        },
                        new
                        {
                            Id = 1002ul,
                            CreatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3378),
                            CreatedBy = 0ul,
                            IsDeleted = false,
                            Name = "API-Admin",
                            UpdatedAt = new DateTime(2024, 5, 16, 11, 5, 24, 853, DateTimeKind.Local).AddTicks(3379),
                            UpdatedBy = 0ul
                        });
                });

            modelBuilder.Entity("TCC.API.models.authentication.User", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<ulong>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PersonalKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<ulong?>("RoleId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong?>("SettingsId")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UpdatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("SettingsId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TCC.API.Models.data.Address", b =>
                {
                    b.HasOne("TCC.API.models.authentication.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TCC.API.Models.data.Document", b =>
                {
                    b.HasOne("TCC.API.models.authentication.User", "User")
                        .WithMany("Documents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TCC.API.Models.data.Driver", b =>
                {
                    b.HasOne("TCC.API.Models.data.Document", "Document")
                        .WithOne("Driver")
                        .HasForeignKey("TCC.API.Models.data.Driver", "DocumentId");

                    b.HasOne("TCC.API.models.authentication.User", "User")
                        .WithMany("Drivers")
                        .HasForeignKey("UserId");

                    b.Navigation("Document");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TCC.API.Models.data.Settings", b =>
                {
                    b.HasOne("TCC.API.models.authentication.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TCC.API.Models.data.TravelEntry", b =>
                {
                    b.HasOne("TCC.API.Models.data.Address", "Destination")
                        .WithMany("Destinations")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TCC.API.Models.data.Document", "Document")
                        .WithMany("TravelEntries")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TCC.API.Models.data.Driver", "Driver")
                        .WithMany("TravelEntries")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TCC.API.Models.data.Address", "Origin")
                        .WithMany("Origins")
                        .HasForeignKey("OriginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TCC.API.models.authentication.User", "User")
                        .WithMany("TravelEntries")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TCC.API.Models.data.Vehicle", "Vehicle")
                        .WithMany("TravelEntries")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");

                    b.Navigation("Document");

                    b.Navigation("Driver");

                    b.Navigation("Origin");

                    b.Navigation("User");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("TCC.API.Models.data.Vehicle", b =>
                {
                    b.HasOne("TCC.API.Models.data.Document", "Document")
                        .WithOne("Vehicle")
                        .HasForeignKey("TCC.API.Models.data.Vehicle", "DocumentId");

                    b.HasOne("TCC.API.models.authentication.User", "User")
                        .WithMany("Vehicles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TCC.API.models.authentication.User", b =>
                {
                    b.HasOne("TCC.API.models.authentication.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.HasOne("TCC.API.Models.data.Settings", "Settings")
                        .WithMany()
                        .HasForeignKey("SettingsId");

                    b.Navigation("Role");

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("TCC.API.Models.data.Address", b =>
                {
                    b.Navigation("Destinations");

                    b.Navigation("Origins");
                });

            modelBuilder.Entity("TCC.API.Models.data.Document", b =>
                {
                    b.Navigation("Driver")
                        .IsRequired();

                    b.Navigation("TravelEntries");

                    b.Navigation("Vehicle")
                        .IsRequired();
                });

            modelBuilder.Entity("TCC.API.Models.data.Driver", b =>
                {
                    b.Navigation("TravelEntries");
                });

            modelBuilder.Entity("TCC.API.Models.data.Vehicle", b =>
                {
                    b.Navigation("TravelEntries");
                });

            modelBuilder.Entity("TCC.API.models.authentication.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("TCC.API.models.authentication.User", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Documents");

                    b.Navigation("Drivers");

                    b.Navigation("TravelEntries");

                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
