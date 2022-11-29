using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.Core.DTOs;
using ProductManagementSystem.Core.Models;
using ProductManagementSystem.Core.Services;

namespace ProductManagementSystem.Core.Services
{
    public interface IProductCurrencyUnitsService : IGenericService<ProductCurrencyUnits>
    {
        public Task<CustomResponseDto<List<ProductCurrencyUnitsDto>>> GetApiAllProductCurrency();
        public Task<List<ProductCurrencyUnitsDto>> GetWebAllProductCurrency();
        public Task<List<ProductCurrencyUnitsDto>> GetWebAllCurrencyAsync();
    }
}
