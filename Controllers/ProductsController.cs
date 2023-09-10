using Microsoft.AspNetCore.Mvc;
using Shopping.Data;
using Shopping.Models;

namespace Shopping.Controllers
{

    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        public ProductsController(AppDbContext db)
        {
            _db = db;
        }

        //GET: /products
        public IActionResult Index()
        {
            var products = _db.Products.ToList();
            ViewData["products"] = products;
            return View();
        }

        //GET: /products/details/id
        public IActionResult Details(int? id)
        {
            var Product = _db.Products.ToList().Find(product => product.Id == id);
            if (id == null || Product == null)
            {
                return View("NotFound");
            }
            ViewData["Product"] = Product;
            return View(Product);
        }

        //GET: /products/additem
        public IActionResult AddItem()
        {
            return View();
        }


        //POST: /products/additem
        [HttpPost]
        public IActionResult AddItem([Bind("Name", "Description", "Price")] ProductModel products)
        {

            _db.Products.Add(products);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
