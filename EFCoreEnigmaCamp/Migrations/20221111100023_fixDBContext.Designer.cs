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
    [Migration("20221111100023_fixDBContext")]
    partial class fixDBContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.StudentAddress", b =>
                {
                    b.HasOne("EFCoreEnigmaCamp.Database.Student", "Student")
                        .WithOne("StudentAddress")
                        .HasForeignKey("EFCoreEnigmaCamp.Database.StudentAddress", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EFCoreEnigmaCamp.Database.Student", b =>
                {
                    b.Navigation("StudentAddress")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}