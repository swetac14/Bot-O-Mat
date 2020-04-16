using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bot_o_mat_swetac14.Models;

namespace bot_o_mat_swetac14.ViewModel
{
    public class SelectRobotFormViewModel
    {
        // public List<RoboType> RoboTypes { get; set; }
        //public IEnumerable<RoboType> RoboTypes { get; set; }
        //public string[] BotType { get; set; }
        //public string[] BotName { get; set; }
        //public IEnumerable<String> BotType { get; set; }
        //public IEnumerable<String> BotName { get; set; }

        public String BotType { get; set; }
        public String BotName { get; set; }
        public IEnumerable<RoboTask> RoboTasks { get; set; }
        public string PageTitle
        {
            get
            {
                return "Select your Robots";
            }

        }

        
    }
}