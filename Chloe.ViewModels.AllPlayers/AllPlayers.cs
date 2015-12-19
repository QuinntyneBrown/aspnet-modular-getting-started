using Chloe.NBAClient.Contracts;
using Chloe.ViewModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.ViewModels.AllPlayers
{
    [Serializable]
    public class AllPlayers : IComponent
    {
        public AllPlayers(INBAClient client)
        {
            this.client = client;
        }

        public dynamic Initialize()
        {
            return client.GetAllPlayers();
        }

        public string Title { get; set; }

        protected readonly INBAClient client;
    }
}
