﻿// <auto-generated />
using System;
using Aircash.Repository.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aircash.Repository.Migrations
{
    [DbContext(typeof(MainEntities))]
    partial class MainEntitiesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aircash.Repository.DataLayer.Models.Hotels.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Address", "dbo");
                });

            modelBuilder.Entity("Aircash.Repository.DataLayer.Models.Hotels.Description", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Description", "dbo");
                });

            modelBuilder.Entity("Aircash.Repository.DataLayer.Models.Hotels.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressID")
                        .HasColumnType("int");

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("ChainCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DescriptionID")
                        .HasColumnType("int");

                    b.Property<string>("HotelId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("DescriptionID");

                    b.ToTable("Hotel", "dbo");
                });

            modelBuilder.Entity("Aircash.Repository.DataLayer.Models.Hotels.Offer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HotelID")
                        .HasColumnType("int");

                    b.Property<int?>("PriceID")
                        .HasColumnType("int");

                    b.Property<string>("RateCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("HotelID");

                    b.HasIndex("PriceID");

                    b.ToTable("Offer", "dbo");
                });

            modelBuilder.Entity("Aircash.Repository.DataLayer.Models.Hotels.Price", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BasePrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Total")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Price", "dbo");
                });

            modelBuilder.Entity("Aircash.Repository.DataLayer.Models.IataCodes.IATA", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("IATA", "IATACode");
                });

            modelBuilder.Entity("Aircash.Repository.DataLayer.Models.Hotels.Hotel", b =>
                {
                    b.HasOne("Aircash.Repository.DataLayer.Models.Hotels.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("Aircash.Repository.DataLayer.Models.Hotels.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionID");

                    b.Navigation("Address");

                    b.Navigation("Description");
                });

            modelBuilder.Entity("Aircash.Repository.DataLayer.Models.Hotels.Offer", b =>
                {
                    b.HasOne("Aircash.Repository.DataLayer.Models.Hotels.Hotel", null)
                        .WithMany("Offers")
                        .HasForeignKey("HotelID");

                    b.HasOne("Aircash.Repository.DataLayer.Models.Hotels.Price", "Price")
                        .WithMany()
                        .HasForeignKey("PriceID");

                    b.Navigation("Price");
                });

            modelBuilder.Entity("Aircash.Repository.DataLayer.Models.Hotels.Hotel", b =>
                {
                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
