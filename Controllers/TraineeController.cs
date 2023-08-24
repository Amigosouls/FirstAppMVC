using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class TraineeController : Controller
    {
        // GET: Trainee

        IList<TraineeDetails> traineeDetails = new List<TraineeDetails>
        {
            new TraineeDetails("Srikanth","20","srikanth@123"),
            new TraineeDetails("Siva","22","siva@223")
        };

        IList<TrainerDetail> trainerDetails = new List<TrainerDetail>
        {
            new TrainerDetail("Thangam ArulSeeli","40","thangam@123"),
            new TrainerDetail("Pallavi","35","pallavi@223")
        };
        public ActionResult TraineeView(int? id)
        {
            if (id == 1)
            {
                return View(traineeDetails);
            }
            else if (id==2)
            {
                return RedirectToAction("TrainerView", "Trainee",new { });
                
            }
            else
            {
                return Content("No details found");
            }
        }

        public ActionResult TrainerView()
        {
            return View(trainerDetails);
        }
        public JsonResult JsonView()
        {
            var trainee = new List<TraineeDetails>
            {
                new TraineeDetails("Vignesh","21","Vicketvicky@gmail.com"),
                new TraineeDetails("Darshan","21","darshan@gmail.com")
            };
            var res = Json(trainee,"application/json",System.Text.Encoding.UTF8,JsonRequestBehavior.AllowGet);
            res.MaxJsonLength = int.MaxValue;
            return res;
        }

        public FileResult FileView()
        {
            return File("~/App_Data/Info.docx", "text/plain");
        }

        public JavaScriptResult AgeCalculate(int id)
        {
            // 
            //var page = "<div id='showAge'></div> Enter Age:<input type='number' id='age'> <button>Calc Age</button> <script> </script>";
            
            int year =System.DateTime.Now.Year;
            var page = "$(document).ready(function () {$('#showAge').html('Your Age is ' + ("+(year - id)+"))});";
            
            return new JavaScriptResult() { Script = page };
        }

        public ActionResult Age()
        {

            return View();
        }

    }
}