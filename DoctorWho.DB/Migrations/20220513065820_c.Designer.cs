﻿// <auto-generated />
using System;
using DoctorWho.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoctorWho.DB.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20220513065820_c")]
    partial class c
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoctorWho.DB.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Mohamed"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Ahmed"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Aseel"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Omar"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Marwa"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Models.Companion", b =>
                {
                    b.Property<int>("CompanionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionID");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionID = 1,
                            CompanionName = "NAME1",
                            WhoPlayed = "W1"
                        },
                        new
                        {
                            CompanionID = 2,
                            CompanionName = "NAME2",
                            WhoPlayed = "W2"
                        },
                        new
                        {
                            CompanionID = 3,
                            CompanionName = "NAME3",
                            WhoPlayed = "W3"
                        },
                        new
                        {
                            CompanionID = 4,
                            CompanionName = "NAME4",
                            WhoPlayed = "W4"
                        },
                        new
                        {
                            CompanionID = 5,
                            CompanionName = "NAME5",
                            WhoPlayed = "W5"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.HasAlternateKey("DoctorNumber");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Hani",
                            DoctorNumber = 1,
                            FirstEpisodeDate = new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1970, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Huda",
                            DoctorNumber = 2,
                            FirstEpisodeDate = new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1978, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Nada",
                            DoctorNumber = 3,
                            FirstEpisodeDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1978, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Ali",
                            DoctorNumber = 4,
                            FirstEpisodeDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(1978, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "salam",
                            DoctorNumber = 5,
                            FirstEpisodeDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Models.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemy");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "this is description",
                            EnemyName = "enemy1"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "this is description",
                            EnemyName = "enemy1"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "this is description",
                            EnemyName = "enemy1"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "this is description",
                            EnemyName = "enemy1"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "this is description",
                            EnemyName = "enemy1"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Models.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasAlternateKey("SeriesNumber");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("EpisodeNumber")
                        .IsUnique();

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2018, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "type1",
                            SeriesNumber = 1,
                            Tittle = "tittle1"
                        },
                        new
                        {
                            EpisodeId = 2,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "type1",
                            SeriesNumber = 165,
                            Tittle = "tittle2"
                        },
                        new
                        {
                            EpisodeId = 3,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "type1",
                            Notes = "notes3",
                            SeriesNumber = 188,
                            Tittle = "tittle1"
                        },
                        new
                        {
                            EpisodeId = 4,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 4,
                            EpisodeType = "type3",
                            Notes = "notes4",
                            SeriesNumber = 189,
                            Tittle = "tittle4"
                        },
                        new
                        {
                            EpisodeId = 5,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 5,
                            EpisodeType = "type2",
                            Notes = "notes5",
                            SeriesNumber = 181,
                            Tittle = "tittle5"
                        });
                });

            modelBuilder.Entity("DoctorWho.DB.Models.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanionID")
                        .HasColumnType("int");

                    b.Property<int?>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionID");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanion");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnemyID")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyID");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemy");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.Episode", b =>
                {
                    b.HasOne("DoctorWho.DB.Models.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId");

                    b.HasOne("DoctorWho.DB.Models.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWho.DB.Models.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.DB.Models.Companion", "Companion")
                        .WithMany("EpisodeCompanion")
                        .HasForeignKey("CompanionID");

                    b.HasOne("DoctorWho.DB.Models.Episode", "Episode")
                        .WithMany("EpisodeCompanion")
                        .HasForeignKey("EpisodeId");
                });

            modelBuilder.Entity("DoctorWho.DB.Models.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.DB.Models.Enemy", "Enemy")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EnemyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.DB.Models.Episode", "Episode")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
