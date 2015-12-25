using Chloe.NBAClient.Contracts;
using System.Threading.Tasks;
using Chloe.ViewModels;
using Chloe.ViewComponents.PlayersComponent.Contracts;

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

        public Task InvokeAsync()
        {
            return Task.Run(async () =>
            {
                var result = await client.GetAllPlayersAsync();

                this.Title = result.Resource;
            });
            
        }

        public string Title { get; set; }

        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }

        protected readonly INBAClient client;

        public string ViewLocation { get { return string.Format("Components/_{0}", this.ViewName); } }
    }
}
