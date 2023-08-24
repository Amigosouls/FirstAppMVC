using FirstApp.Models;
using FirstApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        
        public ActionResult Index()
        {
            ViewBag.CompMoto = "If no one can cam's can!";
            ViewData.Add("Title", "CAM Can openers");
            ViewData.Add("Moto", "If no one can cam's can!");
            ViewData.Add("Est", "1983");
            ViewData.Add("Copyright", "Liscenesed under ISO 1911,2000");
            ViewData.Add("Address", "Rockport Internation, Litle Haiti,Vice City ");

            var strArr = new string[5]{
                "HTML","CSS","JAVASCRIPT",".NET","MSSQL"
            };
            ViewBag.SkillSet = strArr;
            
            
            return View();
        }
        public ActionResult ViewEmployee()
        {
            Trainee2Details trainee = new Trainee2Details()
            {
                TraineeName = "Vignesh",
                TraineeAge = "22",
                TraineeEmail = "vignesh@gmail.com"
            };
            Trainer2Detail trainer = new Trainer2Detail()
            {
                TrainerName = "Thangam Arulseeli",
                TrainerAge = "35",
                TrainerEmail = "thangam@gmail.com"
            };

            Employee employee = new Employee()
            {
                Trainee2Details = trainee,
                Trainer2Detail = trainer,
            };
            return View(employee);
        }
    }
}