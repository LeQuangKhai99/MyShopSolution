﻿using MyShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Data.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }

        public List<ProductInCategory> ProductInCategories { set; get; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
