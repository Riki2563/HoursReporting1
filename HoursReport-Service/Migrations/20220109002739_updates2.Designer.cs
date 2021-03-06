// <auto-generated />
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
    [Migration("20220109002739_updates2")]
    partial class updates2
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

            modelBuilder.Entity("HoursReport_Service.Models.ProjectUser", b =>
                {
                    b.Property<int>("ProjectUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProjectUserId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectUser");

                    b.HasData(
                        new
                        {
                            ProjectUserId = 1,
                            ProjectId = 10,
                            UserId = 1
                        },
                        new
                        {
                            ProjectUserId = 2,
                            ProjectId = 20,
                            UserId = 1
                        },
                        new
                        {
                            ProjectUserId = 3,
                            ProjectId = 30,
                            UserId = 1
                        },
                        new
                        {
                            ProjectUserId = 4,
                            ProjectId = 20,
                            UserId = 2
                        },
                        new
                        {
                            ProjectUserId = 5,
                            ProjectId = 30,
                            UserId = 3
                        });
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
                            UserName = "Yosef Coen"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "ShimL8877@gmail.com",
                            Password = "Shim8877",
                            Role = 2,
                            UserName = "Shimon Levi"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "ShoshM8989@gmail.com",
                            Password = "Shosh8989",
                            Role = 2,
                            UserName = "Shoshana Meir"
                        });
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

            modelBuilder.Entity("HoursReport_Service.Models.ProjectUser", b =>
                {
                    b.HasOne("HoursReport_Service.Project", "Project")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HoursReport_Service.User", "User")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HoursReport_Service.Project", b =>
                {
                    b.Navigation("HoursReportings");

                    b.Navigation("ProjectUsers");
                });

            modelBuilder.Entity("HoursReport_Service.User", b =>
                {
                    b.Navigation("HoursReportings");

                    b.Navigation("ProjectUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
