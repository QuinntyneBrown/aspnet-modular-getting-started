using Chloe.Metal.Contracts;
using Chloe.NBAClient.Contracts;
using Chloe.ViewModels.Contracts;
using Chloe.ViewComponents.PlayerComponent.Contracts;
using System;
using System.Collections.Generic;
using Chloe.ViewModels;

namespace Chloe.ViewComponents.PlayerComponent
{
    public class PlayerComponent : IPlayerComponent
    {
        public PlayerComponent(INBAClient client, IRouteParamsProvider routeParamsProvider)
        {
            this.client = client;
            this.ComponentType = ComponentType.Player;
            this.ViewName = "_Player";
        }

        public void Initialize()
        {

        }
        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }

        protected readonly INBAClient client;
    }
}
