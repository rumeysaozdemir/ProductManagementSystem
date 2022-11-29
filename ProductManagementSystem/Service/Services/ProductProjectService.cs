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
    public class ProductProjectService : GenericService<ProductProjects>, IProductProjectsService
    {
        private readonly IProductProjectRepository _productProjectRepository;
        private readonly IMapper _mapper;


        public ProductProjectService(IGenericRepository<ProductProjects> repository, IGenericUnitOfWork unitOfWork, IProductProjectRepository productProjectRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productProjectRepository = productProjectRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductProjectsDto>> GetWebAllProductProjects()
        {
            var productProject = await _productProjectRepository.GetWebAllProductProjectAsync();
            var productProjectDtos = _mapper.Map<List<ProductProjectsDto>>(productProject);
            return productProjectDtos;
        }

        public async Task<CustomResponseDto<List<ProductProjectsDto>>> GetApiAllProductProjects()
        {
            var productProject = await _productProjectRepository.GetApiAllProductProjectAsync();
            var productProjectDtos = _mapper.Map<List<ProductProjectsDto>>(productProject);
            return CustomResponseDto<List<ProductProjectsDto>>.Success(200, productProjectDtos);
        }


        public async Task<List<ProductProjectsDto>> GetWebAllProjectAsync()
        {
            var productProject = await _productProjectRepository.GetWebAllProductProjectAsync();
            var productProjectDtos = _mapper.Map<List<ProductProjectsDto>>(productProject);
            return productProjectDtos;
        }

    }

   


}

