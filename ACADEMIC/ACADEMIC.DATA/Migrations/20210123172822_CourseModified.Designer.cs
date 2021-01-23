﻿// <auto-generated />
using ACADEMIC.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ACADEMIC.DATA.Migrations
{
    [DbContext(typeof(DatabaseService))]
    [Migration("20210123172822_CourseModified")]
    partial class CourseModified
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ACADEMIC.DOMAIN.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<float>("ReferencedPrice")
                        .HasColumnType("real");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ACADEMIC.DOMAIN.Inscription", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Inscriptions");
                });

            modelBuilder.Entity("ACADEMIC.DOMAIN.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ACADEMIC.DOMAIN.Inscription", b =>
                {
                    b.HasOne("ACADEMIC.DOMAIN.Course", "Course")
                        .WithMany("Inscriptions")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ACADEMIC.DOMAIN.Student", "Student")
                        .WithMany("Inscriptions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ACADEMIC.DOMAIN.Course", b =>
                {
                    b.Navigation("Inscriptions");
                });

            modelBuilder.Entity("ACADEMIC.DOMAIN.Student", b =>
                {
                    b.Navigation("Inscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}