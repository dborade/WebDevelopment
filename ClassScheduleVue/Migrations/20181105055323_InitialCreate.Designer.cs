﻿// <auto-generated />
using ClassSchedule.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassSchedule.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181105055323_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("ClassSchedule.Models.ClassScheduler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassCode");

                    b.Property<string>("ClassName");

                    b.Property<string>("EnrolledStudentName");

                    b.Property<string>("Professor");

                    b.Property<string>("TotalEnrollment");

                    b.HasKey("Id");

                    b.ToTable("ClassScheduler");
                });
#pragma warning restore 612, 618
        }
    }
}