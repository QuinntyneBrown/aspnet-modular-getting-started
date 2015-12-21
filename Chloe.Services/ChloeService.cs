using System;
using Chloe.Services.Contracts;
using Chloe.ViewModels.Contracts;
using Chloe.Metal.Contracts;
using System.Web.Mvc;
using Chloe.ViewModels.PlayerComponent.Contracts;
using Chloe.ViewModels.HomeComponent.Contracts;
using Chloe.ViewModels.AllPlayers.Contracts;
using Chloe.ViewModels.FooterComponent.Contracts;
using Chloe.ViewModels.Header.Contracts;
using Chloe.Data.Contracts;
using System.Linq;
using System.Data.Entity;

namespace Chloe.Services
{
    public class ChloeService: IChloeService
    {
        public ChloeService(IChloeUow uow, IRouteParamsProvider routeParamsProvider)
        {
            this.routeParamsProvider = routeParamsProvider;
            this.uow = uow;
        }

        public IPageViewModel GetPageViewModel()
        {
            var pageViewModel = DependencyResolver.Current.GetService<IPageViewModel>();
            var routeName = routeParamsProvider.Get()["routeName"] as string;
            var components = uow.Pages
                .GetAll()
                .Include(x=>x.Components)
                .Where(x => x.RouteName == routeName).First()
                .Components.ToList();

            foreach(var component in components)
            {
                pageViewModel.Components.Add(LocateComponent(component.Name));
            }

            pageViewModel.Initialize();

            return pageViewModel;
        }

        private IComponent LocateComponent(string componentName)
        {
            switch(componentName)
            {
                case "homeComponent":
                    return DependencyResolver.Current.GetService<IHomeComponent>();

                case "playerComponent":
                    return DependencyResolver.Current.GetService<IPlayerComponent>();

                case "playersComponent":
                    return DependencyResolver.Current.GetService<IPlayersComponent>();

                case "headerComponent":
                    return DependencyResolver.Current.GetService<IHeaderComponent>();

                case "footerComponent":
                    return DependencyResolver.Current.GetService<IFooterComponent>();
            }

            throw new NotImplementedException();
        }

        protected readonly IRouteParamsProvider routeParamsProvider;

        protected readonly IChloeUow uow;


    }
}
