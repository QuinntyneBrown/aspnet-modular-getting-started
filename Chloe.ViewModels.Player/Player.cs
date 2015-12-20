using Chloe.NBAClient.Contracts;
using Chloe.ViewModels.Contracts;
using System;
using System.Collections.Generic;

namespace Chloe.ViewModels.Player
{
    public class Player : IComponent
    {
        public Player(INBAClient client)
        {
            this.client = client;
        }

        public void Initialize(Dictionary<string, string> routeParams)
        {
            throw new NotImplementedException();
        }

        protected readonly INBAClient client;
    }
}
