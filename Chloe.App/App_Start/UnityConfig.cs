using Chloe.Configuration;
using Chloe.Configuration.Contracts;
using Chloe.Data;
using Chloe.Data.Contracts;
using Chloe.NBAClient;
using Chloe.NBAClient.Contracts;
using Chloe.Services;
using Chloe.Services.Contracts;
using Chloe.ViewModels;
using Chloe.ViewModels.AllPlayers;
using Chloe.ViewModels.AllPlayers.Contracts;
using Chloe.ViewModels.Contracts;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc5;

namespace Chloe.App
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IDbContext, ChloeContext>();
            container.RegisterType<IChloeUow, ChloeUow>();
            container.RegisterType<IRepositoryProvider, RepositoryProvider>();
            container.RegisterType<IChloeService, ChloeService>();
            container.RegisterType<INBAClient, NBAClient.NBAClient>();
            container.RegisterType<IHome, Home>();
            container.RegisterType<IAllPlayers, AllPlayers>();
            container.RegisterType<IAppConfiguration, AppConfiguration>();
            container.RegisterType<IAppConfigurationProvider, AppConfigurationProvider>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}