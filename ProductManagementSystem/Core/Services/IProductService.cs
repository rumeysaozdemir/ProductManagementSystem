using ProductManagementSystem.Core.DTOs;
using ProductManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Core.Services
{
    public interface IProductService : IGenericService<Products>
    {
        public Task<CustomResponseDto<List<ProductCategoryDto>>> GetApiAllProductsCategorys();
        public Task<List<ProductCategoryDto >> GetWebAllProductsCategorys();
        public Task<List<ProductCategoryDto>> GetWebAllProductsAsync ();


  

    }
}
