using ProductManagementSystem.Core.DTOs;
using ProductManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Core.Services
{
    public interface ICategoryService:IGenericService<Category>
    {
        public Task<CustomResponseDto<CategoryProductDto>> GetApiCategoryIdProductsAsync(int categoryId);
        public Task<CustomResponseDto<CategoryProductDto>> GetApiAllCategoryProductsAsync();
        public Task<List<CategoryProductDto>> GetWebCategoryIdProductsAsync(int categoryId);
        public Task<List<CategoryProductDto>> GetWebAllCategoryProductsAsync();
        public Task<List<CategoryDto>> GetWebAllCategoriesAsync();

    }
}
