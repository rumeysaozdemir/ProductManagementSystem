using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ProductManagementSystem.Core.DTOs;
using ProductManagementSystem.Core.Services;

namespace ProductManagementSystem.Service.Validations
{
    public class ProductBrandDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductBrandDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.ShortCode).NotEmpty().WithMessage("{PropertyShortCode} is required").NotEmpty().WithMessage("{PropertyShortCode} is required");

        }
    }
}
