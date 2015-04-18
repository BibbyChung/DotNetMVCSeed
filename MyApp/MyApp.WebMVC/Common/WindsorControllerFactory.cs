using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Windsor;
using MyApp.Common;

namespace MyApp.WebMVC.Common
{
    /// <summary>
    /// WindsorControllerFactory
    /// </summary>
    public class WindsorControllerFactory : DefaultControllerFactory
    {
        private IWindsorContainer container;

        public WindsorControllerFactory()
        {
            this.container = AppHelper.CastleWindsorContainer;
        }

        public override void ReleaseController(IController controller)
        {
            this.container.Release(controller);
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
                return null;

            return container.Resolve(controllerType) as IController;
        }
    }
}