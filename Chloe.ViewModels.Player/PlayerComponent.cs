using Chloe.Metal.Contracts;
using Chloe.NBAClient.Contracts;
using Chloe.ViewModels.Contracts;
using Chloe.ViewComponents.PlayerComponent.Contracts;
using System;
using System.Collections.Generic;
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

        public void Initialize()
        {

        }

        public Task InvokeAsync()
        {
            return Task.Factory.StartNew<int>(() => {return 1; });
        }

        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }

        protected readonly INBAClient client;

        public string ViewLocation { get { return string.Format("Components/_{0}", this.ViewName); } }
    }
}
