using Chloe.Services.Contracts;
using Chloe.ViewModels.AllPlayers.Contracts;
using Chloe.ViewModels.Contracts;
using Chloe.ViewModels.PlayerComponent.Contracts;

namespace Chloe.Services
{
    public class ChloeService: IChloeService
    {
        public ChloeService(IHome home, IAllPlayers allPlayers, IPlayer player, IPlayerComponent playerComponent)
        {
            this.home = home;
            this.allPlayers = allPlayers;
            this.playerComponent = playerComponent;
            this.player = player;
        }

        public IHome GetHomePageViewModel()
        {            
            home.Components.Add(allPlayers);
            home.Initialize();         
            return home;
        }

        public IPlayer GetPlayerPageViewModel()
        {
            player.Components.Add(playerComponent);
            player.Initialize();
            return player;
        }

        protected readonly IHome home;

        protected readonly IAllPlayers allPlayers;

        protected readonly IPlayer player;

        protected readonly IPlayerComponent playerComponent;

    }
}
