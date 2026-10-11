using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practical6Mvc.Models;

namespace Practical6Mvc.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View(GetProducts());
        }

        // GET: Product/Details/1
        public ActionResult Details(int id)
        {
            Product product = GetProducts().FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return HttpNotFound("Product not found.");
            }

            return View(product);
        }

        private static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Mobile",
                    Description = "Samsung Mobile",
                    Price = 35000,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Laptop",
                    Description = "Dell Laptop",
                    Price = 75000,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Headphones",
                    Description = "Wireless Headphones",
                    Price = 7500,
                    Category = "Electronics"
                }
            };
        }
    }
}
