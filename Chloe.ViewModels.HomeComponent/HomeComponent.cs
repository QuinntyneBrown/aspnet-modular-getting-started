using Chloe.ViewComponents.HomeComponent.Contracts;
using System;
using Chloe.ViewModels;

namespace Chloe.ViewComponents.HomeComponent
{
    public class HomeComponent : IHomeComponent
    {
        public void Initialize()
        {
            this.ComponentType = ComponentType.Home;

            this.ViewName = "Home";
        }

        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }
    }
}
