using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.MicroKernel.Registration;
using MyApp.Common;
using MyApp.Interface.Common;
using MyApp.Models.Entities;
using MyApp.WebMVC.Common;

namespace MyApp.WebMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Initial the ioc framework.
            InitIOC();

            //Set the controller factory to MVC.
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory());
        }

        private void InitIOC()
        {
            string refAssemblyName = "MyApp";

            //controller
            AppHelper.CastleWindsorContainer
                .Register(
                    Classes.FromAssemblyNamed(string.Concat(refAssemblyName, ".WebMVC"))
                        .BasedOn<IController>()
                        .If(t => t.Name.EndsWith("Controller"))
                        .Configure(a => a.LifestyleTransient())
                );

            //service
            AppHelper.CastleWindsorContainer
                .Register(
                    Classes.FromAssemblyNamed(refAssemblyName)
                    .Where(Component.IsInNamespace(string.Concat(refAssemblyName, ".Services")))
                    .WithService.FirstInterface()
                    .Configure(a => a.LifestyleTransient())
                );

            //provider
            AppHelper.CastleWindsorContainer
                .Register(
                    Classes.FromAssemblyNamed(refAssemblyName)
                    .Where(Component.IsInNamespace(string.Concat(refAssemblyName, ".Services.Providers")))
                    .WithService.FirstInterface()
                    .Configure(a => a.LifestyleTransient())
                );

            //unitOfWork
            AppHelper.CastleWindsorContainer
                .Register(
                    Component.For<DbContext>()
                    .ImplementedBy<Northwind>()
                    .LifeStyle.Transient,

                    Component.For<IUnitOfWork>()
                    .ImplementedBy<UnitOfWork>()
                    .LifeStyle.PerWebRequest
                );

        }

    }
}
