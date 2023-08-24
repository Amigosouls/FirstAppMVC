using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace FirstApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        static IList<Products> products = new List<Products>
        {
            new Products(){Id=1, proName="Pen", proCategory="Stationary",proDescription="Writes in PAper",proMade="Plastic",proPrice="35"},
            new Products(){Id=2, proName="Chair",proCategory="HouseHold",proDescription="Helps tom relax while you sit",proMade="Plastic",proPrice="300"}
        };

        public ActionResult Index()
        {
            return View(products);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="Id,proName,proCategory,proDescription,proMade,proPrice")]Products prod)
        {
            if (ModelState.IsValid)
            {
                products.Add(prod);
                return Redirect("Index");
               
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var p = products.Where(pro =>pro.Id == id).FirstOrDefault();
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Products prod)
        {
            var produ = products.Where(s=> s.Id == prod.Id).FirstOrDefault();
            products.Remove(produ);
            products.Add(prod);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var produ = products.Where(pro => pro.Id == id).FirstOrDefault();
            products.Remove(produ);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var produ = products.Where(pro=> pro.Id == id).FirstOrDefault();
            return View(produ);
        }

    }
}