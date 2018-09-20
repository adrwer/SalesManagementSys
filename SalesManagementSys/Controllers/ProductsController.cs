using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesManagementSys.Models;
using SalesManagementSys.ViewModels;

namespace SalesManagementSys.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;
        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            //base.Dispose(disposing); 
            _context.Dispose();
        }
        // GET: Products
        public ActionResult Index()
        {
            var products = _context.Products.Include(path => path.ProductCategory).ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.ProductID == id);
            if (product == null)
                return HttpNotFound();

            return View(product);
        }
        public ActionResult Edit(int id)
        {
            var product = _context.Products.SingleOrDefault(c => c.ProductID == id);

            if (product == null)
                return HttpNotFound();

            var viewmodel = new ProductViewModel
            {
                Product = product,
                ProductCategory = _context.ProductCategories.ToList()
            };

            return View("ProductForm", viewmodel);
        }

        public ActionResult New()
        {
            var productcategories = _context.ProductCategories.ToList();
            var viewmodel = new ProductViewModel
            {
                ProductCategory = productcategories,
                Product = new Product()
                
            };
            return View("ProductForm", viewmodel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Product product)
        {
            if(!ModelState.IsValid)
            {
                var viewmodel = new ProductViewModel
                {
                    Product = product,
                    ProductCategory = _context.ProductCategories.ToList()
                };
                return View("ProductForm", viewmodel);
            }

            if (product.ProductID == 0)
            {
                product.CreatedOn = DateTime.Now;
                _context.Products.Add(product);
            }
               
            else
            {
                var productinDb = _context.Products.Single(p => p.ProductID == product.ProductID);

                productinDb.ProductName = product.ProductName;
                productinDb.ProductDescription = product.ProductDescription;
                productinDb.UnitPrice = product.UnitPrice;
                productinDb.Size = product.Size;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Products");
        }
    }
}