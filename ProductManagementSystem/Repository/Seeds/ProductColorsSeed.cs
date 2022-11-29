using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.Core.Models;



namespace ProductManagementSystem.Repository.Seeds
{
    internal class ProductColorsSeed : IEntityTypeConfiguration<ProductColors>
    {
        public void Configure(EntityTypeBuilder<ProductColors> builder)
        {
            builder.HasData(new ProductColors
            { 
                Id = 1, 
                Name = "Sarı" 
            }

             );
        }
    }
}