using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesManagementSys.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string UnitPrice { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}