using ProductManagementSystem.Core.DTOs;
using ProductManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Core.Services
{
    public interface IProductMeasurementUnitsService :IGenericService<ProductMeasurementUnits>
    {
        public Task<CustomResponseDto<List<ProductMeasurementUnitsDto>>> GetApiAllProductMeasurement();
        public Task<List<ProductMeasurementUnitsDto>> GetWebAllProductMeasurement ();
        public Task<List<ProductMeasurementUnitsDto>> GetWebAllMeasurementAsync();


    }
}
