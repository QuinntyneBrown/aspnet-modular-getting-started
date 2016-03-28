using Chloe.Configuration;
using Chloe.Configuration.Contracts;
using Chloe.Data;
using Chloe.Data.Contracts;
using Chloe.Metal;
using Chloe.Metal.Contracts;
using Chloe.NBAClient.Contracts;
using Chloe.Services;
using Chloe.Services.Contracts;
using Chloe.ViewModels.Contracts;
using Chloe.ViewComponents.FooterComponent;
using Chloe.ViewComponents.FooterComponent.Contracts;
using Chloe.ViewComponents.HeaderComponent.Contracts;
using Chloe.ViewComponents.HeaderComponent;
using Chloe.ViewComponents.HomeComponent;
using Chloe.ViewComponents.HomeComponent.Contracts;
using Chloe.ViewComponents.PlayerComponent;
using Chloe.ViewComponents.PlayerComponent.Contracts;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc5;
using Chloe.ViewModels;
using Chloe.ViewComponents.PlayersComponent.Contracts;
using Chloe.ViewComponents.PlayersComponent;
using Chloe.ViewComponents.Contracts;
//using Chloe.ViewComponents.HelloWorldComponent;

namespace Chloe.Web
{
    public static class UnityConfig
    {
        public static IUnityContainer Container;

        public static void RegisterComponents()
        {
			Container = new UnityContainer();
            Container.RegisterType<IDbContext, ChloeContext>();
            Container.RegisterType<IChloeUow, ChloeUow>();
            Container.RegisterType<IRepositoryProvider, RepositoryProvider>();
            Container.RegisterType<IChloeService, ChloeService>();
            Container.RegisterType<INBAClient, NBAClient.NBAClient>();
            Container.RegisterType<IHomeComponent, HomeComponent>();
            Container.RegisterType<IPlayersComponent, PlayersComponent>();
            Container.RegisterType<IAppConfiguration, AppConfiguration>();
            Container.RegisterType<IAppConfigurationProvider, AppConfigurationProvider>();
            Container.RegisterType<IRouteParamsProvider, RouteParamsProvider>();
            Container.RegisterType<IPageViewModel, PageViewModel>();
            Container.RegisterType<IPlayerComponent, PlayerComponent>();
            Container.RegisterType<IHeaderComponent, HeaderComponent>();
            Container.RegisterType<IFooterComponent, FooterComponent>();
            Container.RegisterType<IMetaDataViewModel, MetaDataViewModel>();
            Container.RegisterType<IContainerProvider, ContainerProvider>();
            Container.RegisterType<IHelloWorldComponent, Chloe.ViewComponents.HelloWorldComponent.HelloWorldComponent>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(Container));
        }
    }
}