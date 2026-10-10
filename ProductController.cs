using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using productcatelog.Models;

namespace productcatelog.Controllers
{
    public class ProductController : Controller
    {
        // In-memory product list matching the product catalog practical
        private static List<product> productList = new List<product>
        {
            new product 
            { 
                ProductId = 1, 
                ProductName = "Laptop", 
                Description = "High performance laptop", 
                Price = 55000, 
                Category = "Electronics" 
            },
            new product 
            { 
                ProductId = 2, 
                ProductName = "Headphones", 
                Description = "Noise cancelling headphones", 
                Price = 2500, 
                Category = "Accessories" 
            },
            new product 
            { 
                ProductId = 3, 
                ProductName = "Keyboard", 
                Description = "Mechanical RGB keyboard", 
                Price = 3500, 
                Category = "Accessories" 
            }
        };

        // GET: /Product/ or /Product/Index
        public ActionResult Index()
        {
            return View(productList);
        }

        // GET: /Product/Details/{id}
        public ActionResult Details(int id)
        {
            var item = productList.FirstOrDefault(p => p.ProductId == id);
            return View(item);
        }
    }
}
