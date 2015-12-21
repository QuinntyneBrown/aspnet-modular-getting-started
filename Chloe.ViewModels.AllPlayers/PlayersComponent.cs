using Chloe.NBAClient.Contracts;
using Chloe.ViewComponents.Players.Contracts;
using Chloe.ViewModels;

namespace Chloe.ViewComponents.PlayersComponent
{
    public class PlayersComponent :  IPlayersComponent
    {
        public PlayersComponent(INBAClient client)
        {
            this.client = client;
            this.ComponentType = ComponentType.Players;
            this.ViewName = "_Players";
        }

        public void Initialize()
        {
            var allPlayers = client.GetAllPlayers();
        }

        public string Title { get; set; }

        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }

        protected readonly INBAClient client;        
    }
}
