using ProductManagementSystem.Repository.AppDbContexts.AppDbContext;
using ProductManagementSystem.Repository;
using ProductManagementSystem.Core.Repositories;
using ProductManagementSystem.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using ProductManagementSystem.Repository.UnitOfWorks;
using System.Net.Sockets;
using ProductManagementSystem.Core;
using ProductManagementSystem.Service.Services;
using ProductManagementSystem.Service.Mapping;
using ProductManagementSystem.Core.Services;
using FluentValidation;
using ProductManagementSystem.Core.DTOs;
using FluentValidation.AspNetCore;
using ProductManagementSystem.Service.Validations;
using ProductManagementSystem.API.Filters;
using Microsoft.AspNetCore.Mvc;
using ProductManagementSystem.API.Middlewares;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using ProductManagementSystem.API.Modules;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepositoryServicesModules()));

builder.Services.AddControllers(options => options.Filters.Add(new ValidateFilterAttribute())).AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductDtoValidator>());
builder.Services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped(typeof(NotFoundFilter<>));
builder.Services.AddAutoMapper(typeof(MapProfiles));


// Biz yazýyoruz
builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnetion"), option  =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

// Ýsme göre deðil tipe göre çekiyoruz



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCustomException();


app.MapControllers();

app.Run();
