﻿// <auto-generated />
using System;
using Hostlify.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hostlify.Infraestructure.Migrations
{
    [DbContext(typeof(HostlifyDB))]
    [Migration("20230504193353_PersonalPlanTableActive")]
    partial class PersonalPlanTableActive
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Hostlify.Infraestructure.CleaningServices", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 5, 4, 14, 33, 53, 145, DateTimeKind.Local).AddTicks(8528));

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("instruction")
                        .HasMaxLength(999)
                        .HasColumnType("varchar(999)");

                    b.Property<int>("roomId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("CleaningServices", (string)null);
                });

            modelBuilder.Entity("Hostlify.Infraestructure.FoodServices", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 5, 4, 14, 33, 53, 145, DateTimeKind.Local).AddTicks(7896));

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("cream")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("creamQuantity")
                        .HasColumnType("int");

                    b.Property<string>("dish")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("dishQuantity")
                        .HasColumnType("int");

                    b.Property<string>("drink")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("drinkQuantity")
                        .HasColumnType("int");

                    b.Property<string>("instruction")
                        .HasMaxLength(999)
                        .HasColumnType("varchar(999)");

                    b.Property<int>("roomId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("FoodServices", (string)null);
                });

            modelBuilder.Entity("Hostlify.Infraestructure.History", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 5, 4, 14, 33, 53, 145, DateTimeKind.Local).AddTicks(6666));

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<string>("endDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("guestName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("initialDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("managerId")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("roomName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("id");

                    b.ToTable("History", (string)null);
                });

            modelBuilder.Entity("Hostlify.Infraestructure.PersonalPlan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 5, 4, 14, 33, 53, 145, DateTimeKind.Local).AddTicks(9099));

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<int>("managerId")
                        .HasColumnType("int");

                    b.Property<int>("roomsLimit")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("PersonalPlans", (string)null);
                });

            modelBuilder.Entity("Hostlify.Infraestructure.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 5, 4, 14, 33, 53, 145, DateTimeKind.Local).AddTicks(5630));

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(999)
                        .HasColumnType("varchar(999)");

                    b.Property<bool>("Emergency")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("EndDate")
                        .HasColumnType("longtext");

                    b.Property<int?>("GuestId")
                        .HasColumnType("int");

                    b.Property<string>("InitialDate")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<bool>("ServicePending")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("Rooms", (string)null);
                });

            modelBuilder.Entity("Hostlify.Infraestructure.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 5, 4, 14, 33, 53, 145, DateTimeKind.Local).AddTicks(790));

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Plan")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
