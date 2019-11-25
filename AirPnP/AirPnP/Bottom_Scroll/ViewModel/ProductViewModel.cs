using System;
using System.Collections.Generic;
using System.Text;
using Bottom_Scroll.Model;
using Bottom_Scroll.Service;

namespace Bottom_Scroll.ViewModel
{
  public class ProductViewModel
     {
        public List<Product> Products { get; set; }

        public ProductViewModel()
        {
            Products = new ProductService().GetProductsList();
        }
    }
}
