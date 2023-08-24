using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    [RoutePrefix("routes")]
    public class CustomerController : Controller
    {
        // GET: Customer
        //[Route("Index/{id}")]
        //public ActionResult Index(int? id)
        //{
        //    if (id == null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return Content("id has value:" + id);
        //    }

        //}

        //overrided
        [Route("~/route/{id}")]
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                return Content("id has value:" + id);
            }

        }

        [Route("~/Customer/ViewName/{Name:alpha:length(4,16)}")]
        public ActionResult Name(string name) {

            return Content("Your name is " + name);
        }
        [Route("~/Customer/State/{state:bool}")]
        public ActionResult State(bool state)
        {
            return Content("The state is " + state);
        }
        [Route("~/Customer/Regex/{reg:regex(^[A-Za-z0-9]+$)}")]
        public ActionResult Regex(string reg) {
            return Content("The flollowing string matched pattern:" + reg);
        
        }

    }
}