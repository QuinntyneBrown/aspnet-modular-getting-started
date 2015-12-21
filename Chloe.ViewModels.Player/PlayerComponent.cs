using Chloe.Metal.Contracts;
using Chloe.NBAClient.Contracts;
using Chloe.ViewModels.Contracts;
using Chloe.ViewModels.PlayerComponent.Contracts;
using System;
using System.Collections.Generic;

namespace Chloe.ViewModels.PlayerComponent
{
    public class PlayerComponent : IPlayerComponent
    {
        public PlayerComponent(INBAClient client, IRouteParamsProvider routeParamsProvider)
        {
            this.client = client;
            this.routeParams = routeParamsProvider.Get();
        }

        public void Initialize()
        {

        }

        protected readonly INBAClient client;

        protected readonly Dictionary<string, object> routeParams;
    }
}
