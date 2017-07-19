using DAL.UnitOfWorks;
using Interfaces.DAL;
using Interfaces.Service;
using Microsoft.Practices.Unity;
using Services.Products;
using System.Web.Mvc;
using Unity.Mvc5;

namespace TrainingApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IProductService, ProductService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}