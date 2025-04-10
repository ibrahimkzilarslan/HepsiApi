﻿using Bogus;
using Hepsi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepsi.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");

            Product product = new()
            {
                Id = 1,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 1,
                Price = faker.Finance.Amount(10,1000),
                Discount = faker.Random.Decimal(0, 100),
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Product product2 = new()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 2,
                Price = faker.Finance.Amount(10, 1000),
                Discount = faker.Random.Decimal(0, 100),
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            builder.HasData(product, product2);
        }
    }
}
