using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoursReport_Service
{
    public class HoursReporting
    {
        [Key]
        public int HoursReportingId { get; set; }
        [Required]
        public DateTime Date  { get; set; }
        [Required]
        public string BegingingTime { get; set; }
        [Required]
        public string EndTime { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ProjectId { get; set; }

        public User User { get; set; }
        public Project Project { get; set; }


    }
}
