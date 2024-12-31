using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "/images/31.jpg", ProductName = "Nike Kadın Forma", Price = 5_000, ShowCase = false },
                new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "/images/32.jpg", ProductName = "Türkiye Voleybol Forma", Price = 3_000, ShowCase = false },
                new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/images/33.jpg", ProductName = "Adidas Forma", Price = 4500, ShowCase = false },
                new Product() { ProductId = 4, CategoryId = 2, ImageUrl = "/images/34.jpg", ProductName = "Basketbol Forması Erkek", Price = 5_500, ShowCase = false },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/35.jpg", ProductName = "Adidas Eşofman Altı Kadın", Price = 4_499, ShowCase = false },
                new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "/images/26.jpg", ProductName = "Nike Air Max Ltd 3 Siyah", Price = 43503, ShowCase = false },
                new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "/images/27.jpg", ProductName = "Puma Rebound V6 Low Yeşil", Price = 2275, ShowCase = false },
                new Product() { ProductId = 8, CategoryId = 1, ImageUrl = "/images/28.jpg", ProductName = "Puma Rebound V6 Low Kırmızı", Price = 2925, ShowCase = true },
                new Product() { ProductId = 9, CategoryId = 1, ImageUrl = "/images/29.jpg", ProductName = "Nike Court Vision Mid Wntr Sarı", Price = 4950, ShowCase = true },
                new Product() { ProductId = 10, CategoryId = 1, ImageUrl = "/images/30.jpg", ProductName = "Skechers D'Lux Walker Gri", Price = 5499, ShowCase = true },
                new Product() { ProductId = 11, CategoryId = 2, ImageUrl = "/images/36.jpg", ProductName = "Eşofman Altı Turuncu Kadın", Price = 2000, ShowCase = false },
                new Product() { ProductId = 12, CategoryId = 2, ImageUrl = "/images/37.jpg", ProductName = "Nike Mavi Eşofman Erkek", Price = 3500, ShowCase = true },
                new Product() { ProductId = 13, CategoryId = 2, ImageUrl = "/images/38.jpg", ProductName = "Puma Bej Eşofman", Price = 3200, ShowCase = false },
                new Product() { ProductId = 14, CategoryId = 2, ImageUrl = "/images/39.jpg", ProductName = "Puma T-shirt Siyah Kadın", Price = 1500, ShowCase = true },
                new Product() { ProductId = 15, CategoryId = 2, ImageUrl = "/images/40.jpg", ProductName = "Puma T-shirt Kadın", Price = 1950, ShowCase = false },
                new Product() { ProductId = 16, CategoryId = 2, ImageUrl = "/images/41.jpg", ProductName = "North Face Yeşil Erkek", Price = 2250, ShowCase = true },
                new Product() { ProductId = 17, CategoryId = 2, ImageUrl = "/images/42.jpg", ProductName = "Nike Gri T-shirt Erkek", Price = 2500, ShowCase = false }


            );
        }
    }
}