using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class TrainerController : Controller
    {
        // GET: Trainer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewTrainer() {
            List<Trainer2Detail> trainer = new List<Trainer2Detail>()
            {
                new Trainer2Detail {TrainerName="Thangam Arulseeli",TrainerAge="35",TrainerEmail="thangam@123"},
                new Trainer2Detail {TrainerName="Pallavi",TrainerAge="33",TrainerEmail="pallavi@123"}

            };
            return View(trainer);
        }
    }
}