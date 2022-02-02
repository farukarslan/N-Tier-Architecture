using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.CategoryID).NotEmpty().WithMessage("A product must be in a category.");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("Category name can't be exceed 50 characters.");
        }
    }
}
