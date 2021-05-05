﻿// <auto-generated />
using System;
using FakeXiecheng.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FakeXiecheng.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210424025930_DataSeeding")]
    partial class DataSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FakeXiecheng.Moldes.TouristRoute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DepartureTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descrption")
                        .IsRequired()
                        .HasColumnType("varchar(1500) CHARACTER SET utf8mb4")
                        .HasMaxLength(1500);

                    b.Property<double?>("DiscountPresent")
                        .HasColumnType("double");

                    b.Property<string>("Features")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Fees")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("TouristRoutes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f12b5758-4ff1-4d5d-81e8-d643123c3a31"),
                            CreateTime = new DateTime(2021, 4, 24, 2, 59, 29, 588, DateTimeKind.Utc).AddTicks(9607),
                            Descrption = "shuoming",
                            OriginalPrice = 0m,
                            Title = "ceshititle"
                        });
                });

            modelBuilder.Entity("FakeXiecheng.Moldes.TouristRoutePicture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<Guid>("TouristRouteId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Url")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("TouristRouteId");

                    b.ToTable("TouristRoutePictures");
                });

            modelBuilder.Entity("FakeXiecheng.Moldes.TouristRoutePicture", b =>
                {
                    b.HasOne("FakeXiecheng.Moldes.TouristRoute", "TouristRoute")
                        .WithMany("TouristRoutePictures")
                        .HasForeignKey("TouristRouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}