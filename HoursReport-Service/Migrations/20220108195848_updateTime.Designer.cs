﻿// <auto-generated />
using System;
using HoursReport_Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HoursReport_Service.Migrations
{
    [DbContext(typeof(HoursReportingContext))]
    [Migration("20220108195848_updateTime")]
    partial class updateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HoursReport_Service.HoursReporting", b =>
                {
                    b.Property<int>("HoursReportingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BegingingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("HoursReportingId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("HoursReporting");
                });

            modelBuilder.Entity("HoursReport_Service.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProjectId");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectId = 10,
                            ProjectName = "Biosense"
                        },
                        new
                        {
                            ProjectId = 20,
                            ProjectName = "KsharimPlus"
                        },
                        new
                        {
                            ProjectId = 30,
                            ProjectName = "Inetap"
                        });
                });

            modelBuilder.Entity("HoursReport_Service.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "YosefC1122@gmail.com",
                            Password = "Yos1122",
                            Role = 1,
                            UserName = "יוסף כהן"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "ShimL8877@gmail.com",
                            Password = "Shim8877",
                            Role = 2,
                            UserName = "שמעון לוי"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "ShoshM8989@gmail.com",
                            Password = "Shosh8989",
                            Role = 2,
                            UserName = "שושנה מחפוד"
                        });
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.Property<int>("ProjectsProjectId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("ProjectsProjectId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("HoursReport_Service.HoursReporting", b =>
                {
                    b.HasOne("HoursReport_Service.Project", "Project")
                        .WithMany("HoursReportings")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HoursReport_Service.User", "User")
                        .WithMany("HoursReportings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.HasOne("HoursReport_Service.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HoursReport_Service.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HoursReport_Service.Project", b =>
                {
                    b.Navigation("HoursReportings");
                });

            modelBuilder.Entity("HoursReport_Service.User", b =>
                {
                    b.Navigation("HoursReportings");
                });
#pragma warning restore 612, 618
        }
    }
}
