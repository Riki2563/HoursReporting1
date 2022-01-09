using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoursReport_Service.Models
{
    public class ProjectUser
    {
        [Key]
        public int ProjectUserId { get; set; }
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public int UserId { get; set; }

        public User User { get; set; }
        public Project Project { get; set; }
    }
}
