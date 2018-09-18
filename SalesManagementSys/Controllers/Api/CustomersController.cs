using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SalesManagementSys.Models;

namespace SalesManagementSys.Controllers.Api
{
    public class CustomersController : ApiController
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerID == id);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return customer;
        }
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }
        [HttpPut]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerinDb = _context.Customers.Single(c => c.CustomerID == customer.CustomerID);

            if (customerinDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            customerinDb.FirstName = customer.FirstName;
            customerinDb.LastName = customer.LastName;
            customerinDb.Sex = customer.Sex;
            customerinDb.DateofBirth = customer.DateofBirth;
            customerinDb.Address = customer.Address;
            customerinDb.State = customer.State;
            customerinDb.Street = customer.Street;
            customerinDb.MobileNo = customer.MobileNo;
            customerinDb.PhoneNo = customer.PhoneNo;

            _context.SaveChanges();
        }
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerinDb = _context.Customers.Single(c => c.CustomerID == id);
            if (customerinDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerinDb);
            _context.SaveChanges();
        }
    }
}
