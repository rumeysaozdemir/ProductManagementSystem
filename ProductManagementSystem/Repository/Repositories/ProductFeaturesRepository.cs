﻿using ProductManagementSystem.Repository.AppDbContexts.AppDbContext;
using ProductManagementSystem.Core.Models;
using ProductManagementSystem.Core;
using ProductManagementSystem.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Repository.Repositories
{
    public class ProductFeaturesRepository : GenericRepository<ProductFeatures>, IProductFeaturesRepository
    {
        public ProductFeaturesRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<List<ProductFeatures>> GetApiAllProductFeaturesAsync()
        {
            return await _context.ProductFeatures.ToListAsync();
        }

        public async Task<List<ProductFeatures>> GetWebAllProductFeaturesAsync()
        {
            return await _context.ProductFeatures.Include(x => x.Products).Include(c => c.ProductColors).ToListAsync();
        }
    }
}
