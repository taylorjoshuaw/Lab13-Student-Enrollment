﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using StudentEnrollment.Data;
using StudentEnrollment.Models;
using System;

namespace StudentEnrollment.Migrations
{
    [DbContext(typeof(StudentEnrollmentDbContext))]
    [Migration("20180410030225_currentCourseId")]
    partial class currentCourseId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentEnrollment.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Iteration")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("Level");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Technology");

                    b.HasKey("ID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("StudentEnrollment.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentCourseId");

                    b.Property<DateTime>("EnrollmentDate");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<int>("HighestCourseLevel");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<bool>("PassedInterview");

                    b.Property<bool>("Placed");

                    b.HasKey("ID");

                    b.HasIndex("CurrentCourseId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentEnrollment.Models.Student", b =>
                {
                    b.HasOne("StudentEnrollment.Models.Course", "CurrentCourse")
                        .WithMany()
                        .HasForeignKey("CurrentCourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
