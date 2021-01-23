using ACADEMIC.APPLICATION;
using ACADEMIC.DOMAIN;
using Microsoft.EntityFrameworkCore;
using System;

namespace ACADEMIC.DATA
{
    public class DatabaseService:DbContext,IDatabaseService
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }

        public DatabaseService(DbContextOptions<DatabaseService> options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"
            //Server=tcp:devmasterperu.database.windows.net,1433;Initial Catalog=AcademicDB;Persist Security Info=False;User ID=student;Password=Qazw3579@_;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inscription>().HasKey(i=> new {i.CourseId,i.StudentId});

            base.OnModelCreating(modelBuilder);
        }
    }
}
