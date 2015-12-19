using Chloe.Data.Contracts;
using Chloe.NBAClient.Contracts;
using Chloe.Services.Contracts;
using Chloe.ViewModels;
using Chloe.ViewModels.AllPlayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Services
{
    public class ChloeService: IChloeService
    {
        public ChloeService(IChloeUow uow, INBAClient client)
        {
            this.client = client;
            this.uow = uow;
        }

        public Home GetHomePageViewModel()
        {
            var viewModel = new Home();
            var allPlayers = new AllPlayers(this.client);
            viewModel.Components.Add(allPlayers.Initialize());            
            return viewModel;
        }

        protected readonly IChloeUow uow;

        protected readonly INBAClient client;
    }
}
