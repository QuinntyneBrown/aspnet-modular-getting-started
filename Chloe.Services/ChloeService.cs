using Chloe.Services.Contracts;
using Chloe.ViewModels.AllPlayers.Contracts;
using Chloe.ViewModels.Contracts;
using System.Net.Http;
using System.Web;
using System;
using System.Collections.Generic;

namespace Chloe.Services
{
    public class ChloeService: IChloeService
    {
        public ChloeService(IHome home, IAllPlayers allPlayers)
        {
            this.home = home;
            this.allPlayers = allPlayers;
        }

        public IHome GetHomePageViewModel(Dictionary<string, string> routeParams = null)
        {            
            home.Components.Add(allPlayers);
            home.Initialize(routeParams);         
            return home;
        }

        protected readonly IHome home;

        protected readonly IAllPlayers allPlayers;
   
    }
}
