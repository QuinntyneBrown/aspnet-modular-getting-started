using Chloe.NBAClient.Contracts;
using Chloe.ViewModels.AllPlayers.Contracts;
using System.Collections.Generic;

namespace Chloe.ViewModels.AllPlayers
{
    public class AllPlayers :  IAllPlayers
    {
        public AllPlayers(INBAClient client)
        {
            this.client = client;
        }

        public void Initialize(Dictionary<string,string> routeParams)
        {
            var allPlayers = client.GetAllPlayers();
        }

        public string Title { get; set; }

        protected readonly INBAClient client;
    }
}
