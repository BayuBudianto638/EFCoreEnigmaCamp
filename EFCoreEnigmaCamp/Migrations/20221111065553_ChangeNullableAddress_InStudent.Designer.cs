﻿// <auto-generated />
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
    [Migration("20221111065553_ChangeNullableAddress_InStudent")]
    partial class ChangeNullableAddressInStudent
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

                    b.Property<string>("Address")
                        .HasColumnType("Nvarchar(200)");

                    b.Property<string>("StudentCode")
                        .IsRequired()
                        .HasColumnType("Nvarchar(20)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)");

                    b.HasKey("StudentId");

                    b.ToTable("Students", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
