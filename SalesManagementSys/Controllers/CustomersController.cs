using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesManagementSys.Models;

namespace SalesManagementSys.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            //base.Dispose(disposing); 
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerID == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerID == id);

            if (customer == null)
                return HttpNotFound();

            return View("New",customer);
        }
        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
               
                return View("New", customer);
            }

            if (customer.CustomerID == 0)
            {
                //customer.CreatedOn = DateTime.Now;
                _context.Customers.Add(customer);
                
            }
           
            else
            {
                var customerinDb = _context.Customers.Single(c => c.CustomerID == customer.CustomerID);

                customerinDb.FirstName = customer.FirstName;
                customerinDb.LastName = customer.LastName;
                customerinDb.Sex = customer.Sex;
                customerinDb.DateofBirth = customer.DateofBirth;
                customerinDb.Address = customer.Address;
                customerinDb.State = customer.State;
                customerinDb.Street = customer.Street;
                customerinDb.MobileNo = customer.MobileNo;
                customerinDb.PhoneNo = customer.PhoneNo;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
        
        public ActionResult Delete(int id)
        {
            var customerinDb = _context.Customers.Single(c => c.CustomerID == id);

            if (customerinDb == null)
                return HttpNotFound();

            _context.Customers.Remove(customerinDb);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
    }
}