using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Abc.Core.CrossCuttingConcerns.Validation.Fluent;

using FluentValidation;

using PostSharp.Aspects;

namespace Abc.Core.Aspects.Postsharp.ValidationAspects
{
    [Serializable]
    public class FluentValidationAspectAttribute : OnMethodBoundaryAspect
    {
        private readonly Type _validatorType;

        public FluentValidationAspectAttribute(Type validatorType)
        {
            _validatorType = validatorType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            Type entityType = _validatorType.BaseType.GetGenericArguments()[0];
            IEnumerable<object> entities = args.Arguments.Where(t => t.GetType() == entityType);

            foreach (object entity in entities)
            {
                ValidationTool.FluentValidate(validator, entity);
            }
        }
    }
}