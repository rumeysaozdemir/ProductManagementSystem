using ProductManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Core.Repositories
{
    public interface IProductBrandsRepository :IGenericRepository<ProductBrands>
    {
        Task<List<ProductBrands>> GetApiAllProductBrandsAsync();
        Task<List<ProductBrands>> GetWebAllProductBrandsAsync();
    }
}
