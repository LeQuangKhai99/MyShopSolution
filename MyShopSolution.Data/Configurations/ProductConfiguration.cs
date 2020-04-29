using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Đặt tên bảng
            builder.ToTable("Products");
            // đặt khóa chính
            builder.HasKey(x => x.ID);
            // not null
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.PromotionPrice).IsRequired();
            // not nul and default value = 0
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
            
        }
    }
}
