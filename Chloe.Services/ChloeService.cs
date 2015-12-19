using Chloe.Services.Contracts;
using Chloe.ViewModels.AllPlayers.Contracts;
using Chloe.ViewModels.Contracts;

namespace Chloe.Services
{
    public class ChloeService: IChloeService
    {
        public ChloeService(IHome home, IAllPlayers allPlayers)
        {
            this.home = home;
            this.allPlayers = allPlayers;
        }

        public IHome GetHomePageViewModel()
        {            
            home.Components.Add(allPlayers);
            home.Initialize();         
            return home;
        }

        protected readonly IHome home;

        protected readonly IAllPlayers allPlayers;
   
    }
}
