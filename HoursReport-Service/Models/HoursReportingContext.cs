using HoursReport_Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoursReport_Service
{
    public class HoursReportingContext :DbContext
    {
        public HoursReportingContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(
                new User() {UserId=1, UserName = "Yosef Coen", Email = "YosefC1122@gmail.com", Password = "Yos1122", Role = 1 },
                new User() { UserId = 2, UserName = "Shimon Levi", Email = "ShimL8877@gmail.com", Password = "Shim8877", Role = 2 },
                new User() { UserId = 3, UserName = "Shoshana Meir", Email = "ShoshM8989@gmail.com", Password = "Shosh8989", Role = 2 });

            modelBuilder.Entity<Project>().HasData(
            new Project() {ProjectId =10, ProjectName="Biosense" },
            new Project() {ProjectId =20, ProjectName="KsharimPlus" },
            new Project() {ProjectId =30, ProjectName ="Inetap" });

            modelBuilder.Entity<ProjectUser>().HasData(
new ProjectUser() { ProjectUserId = 1, ProjectId = 10, UserId = 1 },
new ProjectUser() { ProjectUserId = 2, ProjectId = 20, UserId = 1 },
new ProjectUser() { ProjectUserId = 3, ProjectId = 30, UserId = 1 },
new ProjectUser() { ProjectUserId = 4, ProjectId = 20, UserId = 2 },
new ProjectUser() { ProjectUserId = 5, ProjectId = 30, UserId = 3 });
        }
        public DbSet<User> User { get; set; }
        public DbSet<HoursReporting> HoursReporting { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectUser> ProjectUser { get; set; }


    }
}
