﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230504210857_Initial_Migration")]
    partial class Initial_Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Authorization.Policy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset?>("LastModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Policy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 5, 0, 8, 57, 186, DateTimeKind.Unspecified).AddTicks(9010), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Migration",
                            Name = "SeeAllUsers"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 5, 0, 8, 57, 186, DateTimeKind.Unspecified).AddTicks(9010), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Migration",
                            Name = "UpdateInstructorProfile"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 5, 0, 8, 57, 186, DateTimeKind.Unspecified).AddTicks(9010), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Migration",
                            Name = "UpdateUserProfile"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Authorization.PolicyRole", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("PolicyId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("LastModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RoleId", "PolicyId");

                    b.HasIndex("PolicyId");

                    b.ToTable("PolicyRole");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            PolicyId = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 5, 0, 8, 57, 187, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Migration",
                            Id = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PolicyId = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 5, 0, 8, 57, 187, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Migration",
                            Id = 2
                        },
                        new
                        {
                            RoleId = 2,
                            PolicyId = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 5, 0, 8, 57, 187, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Migration",
                            Id = 2
                        },
                        new
                        {
                            RoleId = 3,
                            PolicyId = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 5, 0, 8, 57, 187, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Migration",
                            Id = 3
                        });
                });

            modelBuilder.Entity("Domain.Entities.Authorization.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset?>("LastModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 5, 0, 8, 57, 187, DateTimeKind.Unspecified).AddTicks(6721), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Migration",
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 5, 0, 8, 57, 187, DateTimeKind.Unspecified).AddTicks(6721), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Migration",
                            Name = "Student"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 5, 0, 8, 57, 187, DateTimeKind.Unspecified).AddTicks(6721), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Migration",
                            Name = "Instructor"
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset?>("LastModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Seeding",
                            Email = "Kathy_Cassin17@gmail.com",
                            FirstName = "Kathy",
                            LastName = "Cassin",
                            Password = "test",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Seeding",
                            Email = "Tiffany.Ankunding46@gmail.com",
                            FirstName = "Tiffany",
                            LastName = "Ankunding",
                            Password = "test",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Seeding",
                            Email = "Manuel.Gleason@yahoo.com",
                            FirstName = "Manuel",
                            LastName = "Gleason",
                            Password = "test",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Seeding",
                            Email = "Eduardo.Jacobs33@hotmail.com",
                            FirstName = "Eduardo",
                            LastName = "Jacobs",
                            Password = "test",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Seeding",
                            Email = "Adrian.Runolfsdottir18@yahoo.com",
                            FirstName = "Adrian",
                            LastName = "Runolfsdottir",
                            Password = "test",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Seeding",
                            Email = "Angie.Stoltenberg@yahoo.com",
                            FirstName = "Angie",
                            LastName = "Stoltenberg",
                            Password = "test",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Seeding",
                            Email = "Miriam0@yahoo.com",
                            FirstName = "Miriam",
                            LastName = "Cremin",
                            Password = "test",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Seeding",
                            Email = "Lela19@gmail.com",
                            FirstName = "Lela",
                            LastName = "Bartell",
                            Password = "test",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Seeding",
                            Email = "Carroll_Willms@gmail.com",
                            FirstName = "Carroll",
                            LastName = "Willms",
                            Password = "test",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)),
                            CreatedBy = "System Seeding",
                            Email = "Dennis.Corwin@yahoo.com",
                            FirstName = "Dennis",
                            LastName = "Corwin",
                            Password = "test",
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("Domain.Entities.Authorization.PolicyRole", b =>
                {
                    b.HasOne("Domain.Entities.Authorization.Policy", "Policy")
                        .WithMany("PolicyRoles")
                        .HasForeignKey("PolicyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Authorization.Role", "Role")
                        .WithMany("PolicyRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Policy");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.Authorization.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Domain.Entities.Authorization.Policy", b =>
                {
                    b.Navigation("PolicyRoles");
                });

            modelBuilder.Entity("Domain.Entities.Authorization.Role", b =>
                {
                    b.Navigation("PolicyRoles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}