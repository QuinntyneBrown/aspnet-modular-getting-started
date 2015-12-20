using Chloe.NBAClient.Contracts;
using Chloe.ViewModels.AllPlayers.Contracts;
using System.Collections.Generic;

namespace Chloe.ViewModels.AllPlayers
{
    public class PlayersComponent :  IPlayersComponent
    {
        public PlayersComponent(INBAClient client)
        {
            this.client = client;
        }

        public void Initialize()
        {
            var allPlayers = client.GetAllPlayers();
        }

        public string Title { get; set; }

        protected readonly INBAClient client;
 
    }
}
