using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalesManagementSys.Models;

namespace SalesManagementSys.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<ProductCategory> ProductCategory { get; set; }
        public Product Product { get; set; }
        public string Title
        {
            get
            {
                if (Product != null && Product.ProductID != 0)
                    return "Edit Product";
                return "New Product";
            }
        }
    }
}