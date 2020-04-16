using bot_o_mat_swetac14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bot_o_mat_swetac14.ViewModel;
using Newtonsoft.Json;

namespace bot_o_mat_swetac14.Controllers
{

    public class SelectRobotController : Controller
    {
        private ApplicationDbContext _context;
        
        public SelectRobotController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: SelectRobot
        public ActionResult Index()
        {
            var roboType = _context.RoboTypes.ToList();
            return View(roboType);
        }

        
        [HttpPost]
        public ActionResult SelectTask(string[] roboVal, string[] nameVal)
        {
            TempData["RoboVal"] = roboVal;
            TempData["NameVal"] = nameVal;
            var roboTasks = _context.RoboTasks.ToList();

           

            List<SelectRobotFormViewModel> robos = new List<SelectRobotFormViewModel>();
            for (int i = 0; i < roboVal.Length; i++)
            {
                robos.Add(new SelectRobotFormViewModel() { BotName = roboVal[i], BotType = nameVal[i], RoboTasks= roboTasks });
            }
            TempData["SelectRobo"] = robos;
            return Json(true);

        }
        [HttpGet]
        public ActionResult SelectTask()
        {                      
            if (TempData.ContainsKey("SelectRobo"))
            {
                TempData.Keep();
               // viewModels = TempData["SelectRobo"] as IEnumerable<SelectRobotFormViewModel>;
            }
             
                TempData.Keep();
            return View() ;
        }





    }
}