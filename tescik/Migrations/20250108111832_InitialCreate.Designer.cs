﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt_bazy.Models;

#nullable disable

namespace Projekt_bazy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250108111832_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Projekt_bazy.Models.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrzynaleznoscDoMagazynu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stopien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wiek")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Personel");
                });

            modelBuilder.Entity("Projekt_bazy.Models.Sprzet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataWstawienia")
                        .HasColumnType("datetime2");

                    b.Property<string>("NazwaMagazynu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazwaSprzetu")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Sprzety");
                });

            modelBuilder.Entity("Projekt_bazy.Models.Zamowienie", b =>
                {
                    b.Property<int>("IdZamowienia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdZamowienia"));

                    b.Property<DateTime>("DataZamowienia")
                        .HasColumnType("datetime2");

                    b.Property<string>("NazwaSprzetu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdZamowienia");

                    b.ToTable("Zamowienia");
                });
#pragma warning restore 612, 618
        }
    }
}
