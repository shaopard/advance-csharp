using System;

using Abc.Northwind.Entities.ConcreteTypes;

using FluentValidation;

namespace Abc.Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage($"Product name should start with \"A\".");
        }

        private bool StartWithA(string productName) => productName.StartsWith($"A", StringComparison.CurrentCultureIgnoreCase);
    }
}