using HoursReport_Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoursReport_Service
{
    public class Project
    {

        [Key]
        public int ProjectId { get; set; }
        [StringLength(50)]
        [Required]
        public string ProjectName { get; set; }

        public ICollection<HoursReporting> HoursReportings { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }

    }
}
