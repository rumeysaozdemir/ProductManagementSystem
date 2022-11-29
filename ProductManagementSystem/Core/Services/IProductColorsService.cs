using ProductManagementSystem.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.Core.Models;
using ProductManagementSystem.Core.Services;

namespace ProductManagementSystem.Core.Services
{
    public interface IProductColorsService:IGenericService<ProductColors>
    { 
        public Task<CustomResponseDto<List<ProductColorsDto>>> GetApiAllProductColors();
        public Task<List<ProductColorsDto>> GetWebAllProductColors();
        public Task<List<ProductColorsDto>> GetWebAllColorsAsync();
    }
}
