using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesManagementSys.Models;

namespace SalesManagementSys.Controllers
{
    public class OrdersController : Controller
    {
        private ApplicationDbContext _context;

        public OrdersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            //base.Dispose(disposing); 
            _context.Dispose();
        }
        // GET: Orders
        public ActionResult Index()
        {
            var orders = _context.Orders.ToList();
            return View(orders);
        }

        public ActionResult Delete(int id)
        {
            var orderinDb = _context.Orders.Single(c => c.OrderID == id);

            if (orderinDb == null)
                return HttpNotFound();

            _context.Orders.Remove(orderinDb);
            _context.SaveChanges();
            return RedirectToAction("Index", "Orders");
        }

        public ActionResult Process(int id)
        {
            var orderinDb = _context.Orders.SingleOrDefault(o => o.OrderID == id);

            orderinDb.Process = true;

            _context.SaveChanges();
            return RedirectToAction("Index", "Orders");
        }
    }
}