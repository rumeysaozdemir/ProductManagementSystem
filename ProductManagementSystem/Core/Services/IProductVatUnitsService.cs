using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.Core.DTOs;
using ProductManagementSystem.Core.Models;

namespace ProductManagementSystem.Core.Services
{
    public interface IProductVatUnitsService :IGenericService<ProductVatUnits>
    {
        public Task<CustomResponseDto<List<ProductVatUnitsDto>>> GetApiAllProductVatUnits ();
        public Task<List<ProductVatUnitsDto>> GetWebAllProductVatUnits();
        public Task<List<ProductVatUnitsDto>> GetWebAllVatAsync();

    }
}
