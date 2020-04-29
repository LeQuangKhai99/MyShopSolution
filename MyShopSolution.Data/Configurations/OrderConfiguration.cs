using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ShipName).IsRequired();
            builder.Property(x => x.ShipPhoneNumber).IsRequired();
            builder.Property(x => x.ShipEmail).IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.ShipAddress).IsRequired();
        }
    }
}
