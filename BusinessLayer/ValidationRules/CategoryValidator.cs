using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name is required.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Category name must be at least 3 characters.");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Category name can't be exceed 20 characters.");
        }
    }
}
