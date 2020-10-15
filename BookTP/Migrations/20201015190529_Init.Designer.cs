﻿// <auto-generated />
using System;
using BookTP;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BookTP.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20201015190529_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BookTP.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Authors")
                        .HasColumnType("text");

                    b.Property<int>("AverageRating")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InfoLink")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<int>("PageCount")
                        .HasColumnType("integer");

                    b.Property<string>("PreviewLink")
                        .HasColumnType("text");

                    b.Property<string>("PrintType")
                        .HasColumnType("text");

                    b.Property<string>("PublishedDate")
                        .HasColumnType("text");

                    b.Property<string>("Publisher")
                        .HasColumnType("text");

                    b.Property<int>("RatingsCount")
                        .HasColumnType("integer");

                    b.Property<Guid?>("ShelveId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ShelveId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookTP.Models.Shelve", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Shelves");
                });

            modelBuilder.Entity("BookTP.Models.Book", b =>
                {
                    b.HasOne("BookTP.Models.Shelve", null)
                        .WithMany("Books")
                        .HasForeignKey("ShelveId");
                });
#pragma warning restore 612, 618
        }
    }
}
