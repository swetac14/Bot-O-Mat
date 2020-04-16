using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bot_o_mat_swetac14.Models
{
    public class SelectRobo
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        public string Name { get; set; }

        public RoboType RoboType { get; set; }
        [Display(Name = "Robo Type")]
        public byte RoboTypeID { get; set; }
    }
}