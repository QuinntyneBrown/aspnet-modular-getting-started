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

namespace Chloe.Services
{
    public class ChloeService: IChloeService
    {
        public ChloeService(IRouteParamsProvider routeParamsProvider)
        {
            this.routeParamsProvider = routeParamsProvider;
        }

        public IPageViewModel GetPageViewModel()
        {
            var pageViewModel = DependencyResolver.Current.GetService<IPageViewModel>();
            pageViewModel.Components.Add(DependencyResolver.Current.GetService<IHeaderComponent>());
            pageViewModel.Components.Add(DependencyResolver.Current.GetService<IFooterComponent>());

            switch (this.routeParamsProvider.Get()["routeName"] as string)
            {
                case "Default":
                    pageViewModel.Components.Add(DependencyResolver.Current.GetService<IHomeComponent>());
                    break;

                case "Player":
                    pageViewModel.Components.Add(DependencyResolver.Current.GetService<IPlayerComponent>());
                    break;

                case "Players":
                    pageViewModel.Components.Add(DependencyResolver.Current.GetService<IPlayersComponent>());
                    break;
            }

            pageViewModel.Initialize();

            return pageViewModel;
        }

        protected readonly IRouteParamsProvider routeParamsProvider;
        
    }
}
