using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesManagementSys.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; } 
        public int Quantity { get; set; }
        public int OrderTotal { get; set; }
        public int UnitPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public bool Process { get; set; }
    }
}