using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Data.Configurations
{
    class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(t => new { t.ProductId, t.CategoryId });

            builder.HasOne(x => x.Product)
                .WithMany(y => y.ProductInCategories)
                .HasForeignKey(z => z.ProductId);

            builder.HasOne(x => x.Category)
                .WithMany(y => y.ProductInCategories)
                .HasForeignKey(z => z.CategoryId);
        }
    }
}
