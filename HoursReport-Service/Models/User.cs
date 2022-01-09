using HoursReport_Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoursReport_Service
{
    public class User
    {

        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        public int Role { get; set; }

        public ICollection<HoursReporting> HoursReportings { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }


    }
}
