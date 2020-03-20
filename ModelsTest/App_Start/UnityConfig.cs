using AutoMapper;
using ModelsTest.Config;
using ModelsTest.Domains;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ModelsTest
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IAccountDomain, AccountDomain>();

            AutoMapperConfiguration.Init();
            container.RegisterInstance<IMapper>(AutoMapperConfiguration.Mapper);
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}