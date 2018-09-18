using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SalesManagementSys.Models
{
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        [StringLength(50)]
        public string Category { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}