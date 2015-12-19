using Chloe.NBAClient.Contracts;
using Chloe.ViewModels.AllPlayers.Contracts;

namespace Chloe.ViewModels.AllPlayers
{
    public class AllPlayers :  IAllPlayers
    {
        public AllPlayers(INBAClient client)
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
