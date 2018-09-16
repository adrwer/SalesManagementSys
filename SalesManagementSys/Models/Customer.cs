using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesManagementSys.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public DateTime CreatedOn { get; set; }


    }
}