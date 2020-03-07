using FluentValidation;
using FluentValidation.Results;

namespace Abc.Core.CrossCuttingConcerns.Validation.Fluent
{
    public static class ValidationTool
    {
        public static void FluentValidate(IValidator validator, object entity)
        {
            ValidationResult result = validator.Validate(entity);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}