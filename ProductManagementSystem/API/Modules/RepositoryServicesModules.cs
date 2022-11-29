using System.Reflection;
using FluentValidation;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ProductManagementSystem.Core;
using ProductManagementSystem.API.Filters;
using ProductManagementSystem.API.Modules;
using System.Threading.Tasks;
using ProductManagementSystem.Core.DTOs;
using ProductManagementSystem.Repository.UnitOfWorks;
using ProductManagementSystem.Service.Exceptions;
using System.Text.Json;
using System.Linq;
using Module = Autofac.Module;
using Autofac.Extensions.DependencyInjection;
using ProductManagementSystem.Repository.Repositories;
using ProductManagementSystem.Core.Repositories;
using ProductManagementSystem.Core.Services;
using ProductManagementSystem.Core.UnitOfWorks;
using ProductManagementSystem.Service.Mapping;
using ProductManagementSystem.Service.Services;
using Autofac;

namespace ProductManagementSystem.API.Modules
{
    public class RepositoryServicesModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ProductColorsRepository>().As<IProductColorsRepository>();
            builder.RegisterType<ProductProjectsRepository>().As<IProductProjectRepository>();
            builder.RegisterType<ProductBrandsRepository>().As<IProductBrandsRepository>();
            builder.RegisterType<ProductCurrencyRepository>().As<IProductCurrencyUnitsRepository>();
            builder.RegisterType<ProductMeasurementRepository>().As<IProductMeasurementUnitsRepository>();
            builder.RegisterType<ProductVatRepository>().As<IProductVatUnitsRepository>();
            builder.RegisterType<ProductWeightRepository>().As<IProductWeightUnitsRepository>();




            builder.RegisterType<CategoryRepository > ().As<ICategoryRepository>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<ProductColorService>().As<IProductColorsService>();
            builder.RegisterType<ProductProjectService>().As<IProductProjectsService>();
            builder.RegisterType<ProductBrandService>().As<IProductBrandsService>();
            builder.RegisterType<ProductCurrencyService>().As<IProductCurrencyUnitsService>();
            builder.RegisterType<ProductMeasurementService>().As<IProductMeasurementUnitsService>();
            builder.RegisterType<ProductVatService>().As<IProductVatUnitsService>();
            builder.RegisterType<ProductWeightService>().As<IProductWeightUnitsService>();


            builder.RegisterType<UnitOfWork>().As<IGenericUnitOfWork>();

            var repository =  Assembly.GetAssembly(typeof(AppContext));
            var service = Assembly.GetAssembly(typeof(MapProfiles));
            var api = Assembly.GetExecutingAssembly();


            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();


        }
    }
}
