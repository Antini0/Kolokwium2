﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kolokwium2.Data;

#nullable disable

namespace kolokwium2.Migrations
{
    [DbContext(typeof(dbContext))]
    partial class dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DefaultNamespace.Title", b =>
                {
                    b.Property<int>("IdTitle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTitle"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdTitle");

                    b.ToTable("Titles");

                    b.HasData(
                        new
                        {
                            IdTitle = 1,
                            Name = "dada"
                        },
                        new
                        {
                            IdTitle = 2,
                            Name = "fafa"
                        });
                });

            modelBuilder.Entity("kolokwium2.Models.Backpack", b =>
                {
                    b.Property<int>("IdCharacter")
                        .HasColumnType("int");

                    b.Property<int>("IdItem")
                        .HasColumnType("int");

                    b.Property<int>("Ammount")
                        .HasColumnType("int");

                    b.HasKey("IdCharacter", "IdItem");

                    b.HasIndex("IdItem");

                    b.ToTable("Backpacks");

                    b.HasData(
                        new
                        {
                            IdCharacter = 1,
                            IdItem = 1,
                            Ammount = 2
                        },
                        new
                        {
                            IdCharacter = 1,
                            IdItem = 2,
                            Ammount = 1
                        });
                });

            modelBuilder.Entity("kolokwium2.Models.Character", b =>
                {
                    b.Property<int>("IdCharacter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCharacter"));

                    b.Property<int>("CurrentWeight")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MaxWeight")
                        .HasColumnType("int");

                    b.HasKey("IdCharacter");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            IdCharacter = 1,
                            CurrentWeight = 67,
                            FirstName = "jan",
                            LastName = "nowak",
                            MaxWeight = 80
                        },
                        new
                        {
                            IdCharacter = 2,
                            CurrentWeight = 55,
                            FirstName = "stefan",
                            LastName = "koski",
                            MaxWeight = 60
                        });
                });

            modelBuilder.Entity("kolokwium2.Models.Character_title", b =>
                {
                    b.Property<int>("IdCharacter")
                        .HasColumnType("int");

                    b.Property<int>("IdTitle")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTime>("AccuiredAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdCharacter", "IdTitle");

                    b.HasIndex("IdTitle");

                    b.ToTable("CharacterTitles");

                    b.HasData(
                        new
                        {
                            IdCharacter = 2,
                            IdTitle = 2,
                            AccuiredAt = new DateTime(2024, 3, 1, 13, 25, 13, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdCharacter = 1,
                            IdTitle = 1,
                            AccuiredAt = new DateTime(2023, 5, 1, 13, 25, 13, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("kolokwium2.Models.Item", b =>
                {
                    b.Property<int>("IdItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdItem"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("IdItem");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            IdItem = 1,
                            Name = "okulary",
                            Weight = 20
                        },
                        new
                        {
                            IdItem = 2,
                            Name = "pilka",
                            Weight = 15
                        });
                });

            modelBuilder.Entity("kolokwium2.Models.Backpack", b =>
                {
                    b.HasOne("kolokwium2.Models.Character", "Character")
                        .WithMany("Backpacks")
                        .HasForeignKey("IdCharacter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kolokwium2.Models.Item", "Item")
                        .WithMany("Backpacks")
                        .HasForeignKey("IdItem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("kolokwium2.Models.Character_title", b =>
                {
                    b.HasOne("kolokwium2.Models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("IdCharacter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DefaultNamespace.Title", "Title")
                        .WithMany()
                        .HasForeignKey("IdTitle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("kolokwium2.Models.Character", b =>
                {
                    b.Navigation("Backpacks");
                });

            modelBuilder.Entity("kolokwium2.Models.Item", b =>
                {
                    b.Navigation("Backpacks");
                });
#pragma warning restore 612, 618
        }
    }
}
