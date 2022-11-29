using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.Core.DTOs;
using ProductManagementSystem.Core.Models;

namespace ProductManagementSystem.Core.Services
{
    public interface IProductBrandsService :IGenericService<ProductBrands>
    {
        public Task<CustomResponseDto<List<ProductBrandsDto>>> GetApiAllProductBrands();
        public Task<List<ProductBrandsDto>> GetWebAllProductBrands();
        public Task<List<ProductBrandsDto>> GetWebAllBrandsAsync();

    }
}
