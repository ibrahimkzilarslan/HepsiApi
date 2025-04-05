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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                ParentId = 0,
                Name = "Elektrik",
                Priorty = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            Category category2 = new()
            {
                Id = 2,
                ParentId = 0,
                Name = "Moda",
                Priorty = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            Category parent1 = new()
            {
                Id = 3,
                ParentId = 1,
                Name = "Bilgisayar",
                Priorty = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            Category parent2 = new()
            {
                Id = 4,
                ParentId = 2,
                Name = "Kadın",
                Priorty = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            builder.HasData(category1, category2, parent1, parent2);
        }
    }  }

