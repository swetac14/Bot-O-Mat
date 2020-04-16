using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bot_o_mat_swetac14.Models
{
    public class RoboTask
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Task { get; set; }
        
        [StringLength(500)]
        public string Description { get; set; }
        public int EstimatedTimeTaken { get; set; }
    }
}