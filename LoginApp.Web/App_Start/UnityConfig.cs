using LoginApp.Core;
using LoginApp.Web.Facades;
using LoginApp.Web.Facades.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace LoginApp.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUserFacade, UserFacade>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}