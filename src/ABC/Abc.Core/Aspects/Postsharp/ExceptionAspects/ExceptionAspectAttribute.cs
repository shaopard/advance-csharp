using System;

using PostSharp.Aspects;

namespace Abc.Core.Aspects.Postsharp.ExceptionAspects
{
    [Serializable]
    public class ExceptionAspectAttribute : OnMethodBoundaryAspect
    {
        //se poate folosi pentru logare exceptii
        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
        }
    }
}