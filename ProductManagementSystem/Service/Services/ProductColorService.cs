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

namespace ProductManagementSystem.Service.Services
{
    public class ProductColorService : GenericService<ProductColors>, IProductColorsService
    {
        private readonly IProductColorsRepository _productColorRepository;
        private readonly IMapper _mapper;


        public ProductColorService(IGenericRepository<ProductColors> repository, IGenericUnitOfWork unitOfWork, IProductColorsRepository productColorRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productColorRepository = productColorRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductColorsDto>> GetWebAllProductColors()
        {
            var productColor = await _productColorRepository.GetWebAllProductColorsAsync();
            var productColorDtos = _mapper.Map<List<ProductColorsDto>>(productColor);
            return productColorDtos;
        }

        public async Task<CustomResponseDto<List<ProductColorsDto>>> GetApiAllProductColors()
        {
            var productColor = await _productColorRepository.GetApiAllProductColorsAsync();
            var productColorDtos = _mapper.Map<List<ProductColorsDto>>(productColor);
            return CustomResponseDto<List<ProductColorsDto>>.Success(200, productColorDtos);
        }


        public async Task<List<ProductColorsDto>> GetWebAllColorsAsync()
        {
            var productColor = await _productColorRepository.GetWebAllProductColorsAsync();
            var productColorDtos = _mapper.Map<List<ProductColorsDto>>(productColor);
            return productColorDtos;
        }

       


    }



}


