using ProductManagementSystem.Core.DTOs;
using ProductManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Core.Services
{
    public interface IProductFeaturesService:IGenericService<ProductFeatures>
    {
        public Task<CustomResponseDto<List<ProductFeaturesDto>>> GetApiAllProductFeatures();
        public Task<List<ProductFeaturesDto>> GetWebAllProductFeatures();

     }
}
