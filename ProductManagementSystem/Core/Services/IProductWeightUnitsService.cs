using ProductManagementSystem.Core.DTOs;
using ProductManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Core.Services
{
    public interface IProductWeightUnitsService : IGenericService<ProductWeightUnits>
    {
        public Task<CustomResponseDto<List<ProductWeightUnitsDto>>> GetApiAllProductWeightUnits();
        public Task<List<ProductWeightUnitsDto>> GetWebAllProductWeightUnits();
        public Task<List<ProductWeightUnitsDto>> GetWebAllWeightAsync();

    }
}
