using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class Trainee2Controller : Controller
    {
        // GET: Trainee2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewTrainee() {
            List<Trainee2Details> trainee = new List<Trainee2Details>()
           {
               new Trainee2Details {TraineeName="Hemanth",TraineeAge="21",TraineeEmail="hema@123"},
               new Trainee2Details {TraineeName="Siva",TraineeAge="22",TraineeEmail="siva@123"}
           };

            return View(trainee);
        }
    }
}