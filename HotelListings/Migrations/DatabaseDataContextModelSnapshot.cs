﻿// <auto-generated />
using HotelListings.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelListings.Migrations
{
    [DbContext(typeof(DatabaseDataContext))]
    partial class DatabaseDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelListings.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "United States",
                            ShortName = "US"
                        },
                        new
                        {
                            Id = 2,
                            Name = "India",
                            ShortName = "IND"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bhamas",
                            ShortName = "BHS"
                        });
                });

            modelBuilder.Entity("HotelListings.Data.Hotles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("hotles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Califonia",
                            CountryId = 1,
                            Name = "Caaan",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 2,
                            Address = "Califonia",
                            CountryId = 1,
                            Name = "KAJI",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 3,
                            Address = "Lucknow",
                            CountryId = 2,
                            Name = "Jakana",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = 4,
                            Address = "Lucknow",
                            CountryId = 2,
                            Name = "Hotel San",
                            Rating = 5.0
                        });
                });

            modelBuilder.Entity("HotelListings.Data.Hotles", b =>
                {
                    b.HasOne("HotelListings.Data.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}