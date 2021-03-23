using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind.Entities.Concrete;

namespace Northwind.WebApplicationUI.Models
{
    public class ProductViewModel
    {
        public List<Product> ProductList { get; set; }
    }
}