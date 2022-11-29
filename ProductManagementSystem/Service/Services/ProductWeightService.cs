using ProductManagementSystem.Core;
using ProductManagementSystem.Core.DTOs;
using ProductManagementSystem.Core.Repositories;
using ProductManagementSystem.Core.Services;
using ProductManagementSystem.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProductManagementSystem.Core.Models;
using ProductManagementSystem.Repository.UnitOfWorks;
using System.Reflection.Metadata.Ecma335;
using ProductManagementSystem.Repository.Repositories;

namespace ProductManagementSystem.Service.Services
{
    public class ProductWeightService : GenericService<ProductWeightUnits>, IProductWeightUnitsService
    {
        private readonly IProductWeightUnitsRepository _productWeightUnitsRepository;
        private readonly IMapper _mapper;

        public ProductWeightService(IGenericRepository<ProductWeightUnits> repository, IGenericUnitOfWork unitOfWork, IProductWeightUnitsRepository productWeightUnitsRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productWeightUnitsRepository = productWeightUnitsRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductWeightUnitsDto>> GetWebAllProductWeightUnits()
        {
            var productWeight = await _productWeightUnitsRepository.GetWebAllProductWeightUnitsAsync();
            var productWeightDtos = _mapper.Map<List<ProductWeightUnitsDto>>(productWeight);
            return productWeightDtos;
        }



        public async Task<CustomResponseDto<List<ProductWeightUnitsDto>>> GetApiAllProductWeightUnits()
        {
            var productWeight = await _productWeightUnitsRepository.GetApiAllProductWeightUnitsAsync();
            var productWeightDtos = _mapper.Map<List<ProductWeightUnitsDto>>(productWeight);
            return CustomResponseDto<List<ProductWeightUnitsDto>>.Success(200, productWeightDtos);
        }


        public async Task<List<ProductWeightUnitsDto>> GetWebAllWeightAsync()
        {
            var productWeight = await _productWeightUnitsRepository.GetWebAllProductWeightUnitsAsync();
            var productWeightDtos = _mapper.Map<List<ProductWeightUnitsDto>>(productWeight);
            return productWeightDtos;
        }




    }

}

