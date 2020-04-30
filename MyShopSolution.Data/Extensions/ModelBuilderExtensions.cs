using Microsoft.EntityFrameworkCore;
using MyShopSolution.Data.Entities;
using MyShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "Home Title", Value = "This is Home page of MyShopSolution" },
                new AppConfig() { Key = "Home description", Value = "This is description of MyShopSolution" },
                new AppConfig() { Key = "Home keyowrd", Value = "This is keyword of MyShopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "Vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "En-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    ID = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,

                },
                new Category()
                {
                    ID = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active,

                });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Áo Nam",
                    LanguageId = "Vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Sản phẩm áo thời trang nam",
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Men Shirt",
                    LanguageId = "En-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "The fasion shirt products for man",
                    SeoTitle = "The fasion shirt products for man",
                }, new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Áo Nữ",
                    LanguageId = "Vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm áo thời trang nữ",
                    SeoTitle = "Sản phẩm áo thời trang nữ",
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Woman Shirt",
                    LanguageId = "En-US",
                    SeoAlias = "woman-shirt",
                    SeoDescription = "The fasion shirt products for woman",
                    SeoTitle = "The fasion shirt products for woman",
                });

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ID = 1,
                    DateCreated = DateTime.Now,
                    Price = 100000,
                    PromotionPrice = 80000,
                    Stock = 0,
                    ViewCount = 0,
                });

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo khoác gucci",
                    LanguageId = "Vi-VN",
                    SeoAlias = "ao-khoac-gucci",
                    SeoDescription = "Áo khoác gucci",
                    SeoTitle = "Áo khoác gucci",
                    Details = "Áo khoác gucci",
                    Description = "Áo khoác gucci"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Gucci jacket",
                    LanguageId = "En-US",
                    SeoAlias = "gucci-jacket",
                    SeoDescription = "Gucci jacket",
                    SeoTitle = "Gucci jacket",
                    Details = "Gucci jacket",
                    Description = "Gucci jacket"
                });

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                {
                    ProductId = 1,
                    CategoryId = 1
                });
        }
    }
}
