using Chloe.Data;
using Chloe.Data.Contracts;
using Chloe.Services;
using Chloe.Services.Contracts;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace Chloe.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IDbContext, ChloeContext>();
            container.RegisterType<IChloeUow, ChloeUow>();
            container.RegisterType<IRepositoryProvider, RepositoryProvider>();
            container.RegisterType<IBookService, BookService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}