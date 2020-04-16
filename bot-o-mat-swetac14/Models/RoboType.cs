using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bot_o_mat_swetac14.Models
{
    public class RoboType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Type of Robot")]
        public string TypeOfRobo { get; set; }
    }
}