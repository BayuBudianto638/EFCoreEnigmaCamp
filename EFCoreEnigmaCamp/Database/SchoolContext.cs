using EFCoreEnigmaCamp.Cores;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigmaCamp.Database
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; } // Table Conjunction
        public DbSet<Parents> Parents { get; set; }

        public DbSet<vw_StudentAddress> vw_StudentAddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional:false);
            var configuration = builder.Build();

            string connStr = configuration.GetConnectionString("DBConnection");

            optionsBuilder
                .UseSqlServer(connStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourses>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<Teacher>().HasData(
                new { TeacherId = 1, FirtName = "Andik", LastName = "Rain" },
                new { TeacherId = 2, FirtName = "Lana", LastName = "Rain" },
                new { TeacherId = 3, FirtName = "Anton", LastName = "Medan" }
                );

            modelBuilder.Entity<Parents>().Property(p => p.ParentId).HasDefaultValueSql("NEWID()"); // disesuaikan dengan DB nya.

            modelBuilder.Entity<Parents>().HasData(
                    new Parents() { ParentId = Guid.NewGuid(), ParentName = "Fugaku", Address = "Konoha" },
                    new Parents() { ParentId = Guid.NewGuid(), ParentName = "Hiashi", Address = "Konoha" }
                );

            modelBuilder.Entity<vw_StudentAddress>(
                vsa => { 
                    vsa.HasNoKey();
                    vsa.ToView("View_StudentAdress");
                });

            modelBuilder.Entity<Student>().Property(lu => lu.LastUpdate).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Student>().Property(lu => lu.LastUpdate).HasDefaultValueSql("GetDate()");

            modelBuilder.Entity<Student>().Property(g => g.Gender)
                .HasConversion(
                    eg => eg.ToString(),
                    eg => (Gender)Enum.Parse(typeof(Gender), eg)
                );
        }
    }
}
