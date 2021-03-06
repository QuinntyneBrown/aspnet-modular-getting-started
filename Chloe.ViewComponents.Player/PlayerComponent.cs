﻿using Chloe.Metal.Contracts;
using Chloe.NBAClient.Contracts;
using Chloe.ViewComponents.PlayerComponent.Contracts;
using Chloe.ViewModels;
using System.Threading.Tasks;

namespace Chloe.ViewComponents.PlayerComponent
{
    public class PlayerComponent : IPlayerComponent
    {
        public PlayerComponent(INBAClient client, IRouteParamsProvider routeParamsProvider)
        {
            this.client = client;
            this.ComponentType = ComponentType.Player;
            this.ViewName = "Player";
        }

        public Task InvokeAsync()
        {
            return Task.Run(() => { return new { }; });
        }

        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }

        protected readonly INBAClient client;

        public string ViewLocation { get { return string.Format("Components/_{0}", this.ViewName); } }
    }
}
