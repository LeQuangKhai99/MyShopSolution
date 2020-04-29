using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyShopSolution.Data.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string SeoAlias { get; set; }

        public List<ProductInCategory> ProductInCategories { set; get; }

        public List<OrderDetail> OrderDetails { set; get; }
    }
}
