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
using Chloe.ViewComponents.FooterComponent;
using Chloe.ViewComponents.FooterComponent.Contracts;
using Chloe.ViewComponents.Header.Contracts;
using Chloe.ViewComponents.HeaderComponent;
using Chloe.ViewComponents.HomeComponent;
using Chloe.ViewComponents.HomeComponent.Contracts;
using Chloe.ViewComponents.PlayerComponent;
using Chloe.ViewComponents.PlayerComponent.Contracts;
using Chloe.ViewComponents.PlayersComponent;
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
            container.RegisterType<IHomeComponent, HomeComponent>();
            container.RegisterType<IPlayersComponent, PlayersComponent>();
            container.RegisterType<IAppConfiguration, AppConfiguration>();
            container.RegisterType<IAppConfigurationProvider, AppConfigurationProvider>();
            container.RegisterType<IRouteParamsProvider, RouteParamsProvider>();
            container.RegisterType<IPageViewModel, PageViewModel>();
            container.RegisterType<IPlayerComponent, PlayerComponent>();
            container.RegisterType<IHeaderComponent, HeaderComponent>();
            container.RegisterType<IFooterComponent, FooterComponent>();
            container.RegisterType<IMetaDataViewModel, MetaDataViewModel>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}