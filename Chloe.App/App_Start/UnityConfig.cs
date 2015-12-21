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
using Chloe.ViewModels;
using Chloe.ViewModels.AllPlayers;
using Chloe.ViewModels.AllPlayers.Contracts;
using Chloe.ViewModels.Contracts;
using Chloe.ViewModels.FooterComponent;
using Chloe.ViewModels.FooterComponent.Contracts;
using Chloe.ViewModels.Header.Contracts;
using Chloe.ViewModels.HeaderComponent;
using Chloe.ViewModels.HomeComponent;
using Chloe.ViewModels.HomeComponent.Contracts;
using Chloe.ViewModels.PlayerComponent;
using Chloe.ViewModels.PlayerComponent.Contracts;
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