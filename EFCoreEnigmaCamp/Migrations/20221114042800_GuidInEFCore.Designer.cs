﻿// <auto-generated />
using System;
using EFCoreEnigmaCamp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreEnigmaCamp.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20221114042800_GuidInEFCore")]
    partial class GuidInEFCore
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.Courses", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("NVarchar(200)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses", "dbo");
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.Parents", b =>
                {
                    b.Property<Guid>("ParentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentName")
                        .IsRequired()
                        .HasColumnType("NVarchar(200)");

                    b.HasKey("ParentId");

                    b.ToTable("Parents", "dbo");

                    b.HasData(
                        new
                        {
                            ParentId = new Guid("b8418d6b-073f-4322-b603-2a74eb2b2373"),
                            Address = "Konoha",
                            ParentName = "Fugaku"
                        },
                        new
                        {
                            ParentId = new Guid("a14420fa-f1e5-4c4f-9a7a-ffb02c83f080"),
                            Address = "Konoha",
                            ParentName = "Hiashi"
                        });
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime?>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<byte?>("Gender")
                        .HasColumnType("tinyint");

                    b.Property<string>("StudentCode")
                        .IsRequired()
                        .HasColumnType("Nvarchar(20)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)");

                    b.HasKey("StudentId");

                    b.ToTable("Students", "dbo");
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.StudentAddress", b =>
                {
                    b.Property<int>("StudentAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentAddressId"));

                    b.Property<string>("Address1")
                        .HasColumnType("NVarchar(200)");

                    b.Property<string>("Address2")
                        .HasColumnType("NVarchar(200)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentAddressId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentAddresses", "dbo");
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.StudentCourses", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CoursesCourseId");

                    b.ToTable("StudentCourses", "dbo");
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("FirtName")
                        .IsRequired()
                        .HasColumnType("NVarchar(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("NVarchar(100)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher", "dbo");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            FirtName = "Andik",
                            LastName = "Rain"
                        },
                        new
                        {
                            TeacherId = 2,
                            FirtName = "Lana",
                            LastName = "Rain"
                        },
                        new
                        {
                            TeacherId = 3,
                            FirtName = "Anton",
                            LastName = "Medan"
                        });
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.Courses", b =>
                {
                    b.HasOne("EFCoreEnigmaCamp.Database.Teacher", "Teachers")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.StudentAddress", b =>
                {
                    b.HasOne("EFCoreEnigmaCamp.Database.Student", "Student")
                        .WithOne("StudentAddress")
                        .HasForeignKey("EFCoreEnigmaCamp.Database.StudentAddress", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.StudentCourses", b =>
                {
                    b.HasOne("EFCoreEnigmaCamp.Database.Courses", "Courses")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreEnigmaCamp.Database.Student", "Students")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.Courses", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.Student", b =>
                {
                    b.Navigation("StudentAddress")
                        .IsRequired();

                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
