using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SalesManagementSys.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Sex { get; set; }
        public DateTime DateofBirth { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string Street { get; set; }
        [StringLength(15)]
        public string MobileNo { get; set; }
        [StringLength(15)]
        public string PhoneNo { get; set; }
        public DateTime CreatedOn { get; set; }


    }
}