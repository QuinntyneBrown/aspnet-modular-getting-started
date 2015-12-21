using Chloe.Configuration;
using Chloe.Configuration.Contracts;
using Chloe.Data;
using Chloe.Data.Contracts;
using Chloe.Metal;
using Chloe.Metal.Contracts;
using Chloe.NBAClient;
using Chloe.NBAClient.Contracts;
using Chloe.Services;
using Chloe.Services.Contracts;
using Chloe.ViewComponents;
using Chloe.ViewComponents.Players;
using Chloe.ViewComponents.Players.Contracts;
using Chloe.ViewComponents.Contracts;
using Chloe.ViewComponents.PlayerComponent;
using Chloe.ViewComponents.PlayerComponent.Contracts;
using Chloe.ViewComponents.PlayersComponent;
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
            container.RegisterType<IChloeService, ChloeService>();
            container.RegisterType<INBAClient, NBAClient.NBAClient>();
            container.RegisterType<IPlayersComponent, PlayersComponent>();
            container.RegisterType<IAppConfiguration, AppConfiguration>();
            container.RegisterType<IAppConfigurationProvider, AppConfigurationProvider>();
            container.RegisterType<IRouteParamsProvider, RouteParamsProvider>();
            container.RegisterType<IPlayerComponent, PlayerComponent>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}