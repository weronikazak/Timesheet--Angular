﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeSheet.API.Data;

namespace timesheet.api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190817224058_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("TimeSheet.API.Data.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName");

                    b.Property<DateTime>("Deadline");

                    b.Property<bool>("IsFinished");

                    b.Property<string>("ProjectName");

                    b.Property<DateTime>("ProjectStart");

                    b.Property<float>("SpentHours");

                    b.Property<int?>("UserId");

                    b.HasKey("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("TimeSheet.API.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TimeSheet.API.Data.Project", b =>
                {
                    b.HasOne("TimeSheet.API.Data.User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}