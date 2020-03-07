using System;
using System.Web.Mvc;

using Ninject;
using Ninject.Modules;

namespace Abc.Core.Utilities.MVC.Infrastructure.Ninject
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;

        public NinjectControllerFactory(params INinjectModule[] modules)
        {
            _kernel = new StandardKernel(modules);
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            IController controllerInstance = (controllerType == null) ? null : (IController)_kernel.Get(controllerType);

            return controllerInstance;
        }
    }
}