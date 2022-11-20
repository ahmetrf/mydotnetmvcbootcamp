using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product(1, "HP ZBook1", 17_000),    
                new Product(2, "HP ZBook2", 1_000),    
                new Product(3, "HP ZBook3", 21_000),    
                new Product(4, "HP ZBook4", 12_000)
            );
        }
    }
}
