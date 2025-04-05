﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SD7501_Assignment2_22053458.Data;

#nullable disable

namespace SD7501_Assignment2_22053458.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250405122216_SeedCategoryData")]
    partial class SeedCategoryData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SD7501_Assignment2_22053458.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Inside of the car",
                            Name = "Interior"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Outside of the car",
                            Name = "Exterior"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Headlights and LED",
                            Name = "Lighting"
                        },
                        new
                        {
                            Id = 4,
                            Description = "To stop the car",
                            Name = "Brakes & Suspension"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Waste coming out of the car",
                            Name = "Exhaust"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Make the car runs",
                            Name = "Engines"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
