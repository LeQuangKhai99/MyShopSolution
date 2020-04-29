using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Data.Configurations
{
    public class AppConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");
            // Chỉ định đây là khóa chính 
            builder.HasKey(x => x.Key);
            // Chỉ định trường này ko đc null
            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
