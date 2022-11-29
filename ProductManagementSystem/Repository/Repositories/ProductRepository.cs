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
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<Products>> GetProductsCategorys()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }


        public async Task<List<Products>> GetWebAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }




        public async Task<List<Products>> GetApiAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }



        public async Task<List<Products>> GetAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetWebAllProductsAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();

        }


    }
}
