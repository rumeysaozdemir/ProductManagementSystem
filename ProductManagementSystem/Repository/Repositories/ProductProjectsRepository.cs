using ProductManagementSystem.Repository.AppDbContexts.AppDbContext;
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
    public class ProductProjectsRepository : GenericRepository<ProductProjects>,IProductProjectRepository 
    {
        public ProductProjectsRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<ProductProjects>> GetProductProjects()
        {
            return await _context.ProductProjects.ToListAsync();
        }


        public async Task<List<ProductProjects>> GetWebAllProductProjectAsync()
        {
            return await _context.ProductProjects.ToListAsync();
        }


        public async Task<List<ProductProjects>> GetApiAllProductProjectAsync()
        {
            return await _context.ProductProjects.ToListAsync();
        }
  

        public async Task<List<ProductProjects>> GetAllProductProjectsAsync()
        {
            return await _context.ProductProjects.ToListAsync();
        }

        public async Task<List<ProductProjects>> GetWebAllProjectsAsync()
        {
            return await _context.ProductProjects.ToListAsync();
        }

    }
}
