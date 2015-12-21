using Chloe.NBAClient.Contracts;
using Chloe.ViewComponents.Players.Contracts;
using Chloe.ViewModels;
using System;
using System.Threading.Tasks;

namespace Chloe.ViewComponents.PlayersComponent
{
    public class PlayersComponent :  IPlayersComponent
    {
        public PlayersComponent(INBAClient client)
        {
            this.client = client;
            this.ComponentType = ComponentType.Players;
            this.ViewName = "Players";
        }

        public void Initialize()
        {
            var allPlayers = client.GetAllPlayers();
        }

        public Task InvokeAsync()
        {
            return Task.Factory.StartNew<int>(() => {return 1; });
        }

        public string Title { get; set; }

        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }

        protected readonly INBAClient client;

        public string ViewLocation { get { return string.Format("Components/_{0}", this.ViewName); } }
    }
}
