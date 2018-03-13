using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using CarManufacturer.WebApp.Controllers;
using CarManufacturer.WebApp.Services;

namespace CarManufacturer.WebApp
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IOrdersService, OrdersServiceMock>();
            container.RegisterType<IController, OrderController>("Order");

            return container;
        }
    }
}