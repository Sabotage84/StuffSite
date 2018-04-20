using StuffSite2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StuffSite2.Controllers
{
    public class MaterialsController : Controller
    {
        // GET: test
        public ActionResult Index(int? id)
        {
            List<Product> products= FeelProducts();
            
            Product temp = null;

            foreach (var item in products)
            {
                if (item.ID == id)
                    temp = item;
            }

            ViewBag.tempProd = temp;
            return View(temp);
        }




        private static List<Product> FeelProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product {ID=1, Name = "FIMO", Image = "/images/81.jpg", Description = "Самая крутая глина в мире! Налетай, торопись покупай глину и лепи живопись)", IsInStock = true, Price = 19.99 });
            products.Add(new Product { ID = 2, Name = "Баба в кокошнике", Image = "/images/df8010200210l.jpg", Description = "Самая крутая глина в мире! Налетай, торопись покупай глину и лепи живопись)", IsInStock = false, Price = 9.99 });
            products.Add(new Product { ID = 3, Name = "ГЛИНА ИЗ БЕРЛИНА", Image = "/images/df8010200190l.jpg", Description = "Самая крутая глина в мире! Налетай, торопись покупай глину и лепи живопись)", IsInStock = true, Price = 29.99 });
            return products;
        }
    }
}