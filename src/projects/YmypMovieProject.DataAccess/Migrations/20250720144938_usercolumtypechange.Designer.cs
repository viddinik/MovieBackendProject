﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YmypMovieProject.DataAccess.Contexts;

#nullable disable

namespace YmypMovieProject.DataAccess.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20250720144938_usercolumtypechange")]
    partial class usercolumtypechange
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<Guid>("ActorsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ActorsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("ActorMovie");
                });

            modelBuilder.Entity("Core.Entity.Concrete.OperationClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("Core.Entity.Concrete.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Entity.Concrete.UserOperationClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("OperationClaimId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("YmypMovieProject.Entity.Entities.Actor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("YmypMovieProject.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7207),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Aksiyon"
                        },
                        new
                        {
                            Id = new Guid("7273912e-16bc-4f94-84ef-0e4417605988"),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7226),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Bilim Kurgu"
                        },
                        new
                        {
                            Id = new Guid("65303e8a-dd56-4ecb-8e26-098c070fba4b"),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7229),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Komedi"
                        },
                        new
                        {
                            Id = new Guid("99d4b41f-c0e8-4572-a938-f09004f3495b"),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7231),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Belgesel"
                        },
                        new
                        {
                            Id = new Guid("99efee70-c270-4c50-ba47-211c7b3fb4c9"),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7234),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Fantastik"
                        },
                        new
                        {
                            Id = new Guid("05657d1c-3b06-40fd-b4fd-7b5b471f6120"),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7239),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Korku"
                        });
                });

            modelBuilder.Entity("YmypMovieProject.Entity.Entities.Director", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b3401950-fc04-481f-9be8-28043b9b762c"),
                            BirthDate = new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7446),
                            Description = "British-American film director, producer, and screenwriter.",
                            FirstName = "Christopher",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Nolan"
                        },
                        new
                        {
                            Id = new Guid("da87c3f6-493d-4dfd-8e5a-2e2cb9fc636d"),
                            BirthDate = new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7454),
                            Description = "American film director, producer, and screenwriter.",
                            FirstName = "Steven",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Spielberg"
                        },
                        new
                        {
                            Id = new Guid("d449cb1f-40a0-449b-a57f-d3527503d2a8"),
                            BirthDate = new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7456),
                            Description = "American film director, producer, screenwriter, and actor.",
                            FirstName = "Martin",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Scorsese"
                        },
                        new
                        {
                            Id = new Guid("96dfff2d-1d69-43d9-b2b4-42483ce4e094"),
                            BirthDate = new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7459),
                            Description = "American filmmaker, actor, and screenwriter.",
                            FirstName = "Quentin",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Tarantino"
                        },
                        new
                        {
                            Id = new Guid("83b1116d-c36e-4e0b-9c5d-721a2edb4feb"),
                            BirthDate = new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7465),
                            Description = "Canadian filmmaker and environmental advocate.",
                            FirstName = "James",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Cameron"
                        });
                });

            modelBuilder.Entity("YmypMovieProject.Entity.Entities.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("DirectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("IMDB")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DirectorId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b11dbd1c-93a8-4fc9-820b-a3d68440957c"),
                            CategoryId = new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7497),
                            Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.",
                            DirectorId = new Guid("b3401950-fc04-481f-9be8-28043b9b762c"),
                            IMDB = 8.8m,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Inception",
                            PublishDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("7697f9a1-315c-4489-a616-94bb20481ba8"),
                            CategoryId = new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7503),
                            Description = "Interstellar movie Nolan..",
                            DirectorId = new Guid("b3401950-fc04-481f-9be8-28043b9b762c"),
                            IMDB = 8.7m,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Interstellar",
                            PublishDate = new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("70b28f64-1d02-4caf-a386-7d83bcec85b5"),
                            CategoryId = new Guid("9cd54e24-2690-40d6-9e03-9607881a1c7c"),
                            CreateAt = new DateTime(2025, 7, 20, 14, 49, 36, 369, DateTimeKind.Utc).AddTicks(7507),
                            Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                            DirectorId = new Guid("b3401950-fc04-481f-9be8-28043b9b762c"),
                            IMDB = 9.0m,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "The Dark Knight",
                            PublishDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("YmypMovieProject.Entity.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YmypMovieProject.Entity.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YmypMovieProject.Entity.Entities.Movie", b =>
                {
                    b.HasOne("YmypMovieProject.Entity.Entities.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YmypMovieProject.Entity.Entities.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Director");
                });

            modelBuilder.Entity("YmypMovieProject.Entity.Entities.Category", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("YmypMovieProject.Entity.Entities.Director", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
