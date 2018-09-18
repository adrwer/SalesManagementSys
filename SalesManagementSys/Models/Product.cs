using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SalesManagementSys.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        [StringLength(255)]
        public string ProductDescription { get; set; }
        public int UnitPrice { get; set; }
        public int Size { get; set; }
        public DateTime? CreatedOn { get; set; }
        public ProductCategory ProductCategory { get; set; }
        [Display(Name = "Product Category")]
        public int ProductCategoryID { get; set; }
    }
}