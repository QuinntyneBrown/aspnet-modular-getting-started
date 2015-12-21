using Chloe.ViewComponents.Header.Contracts;
using Chloe.ViewModels;
using System;

namespace Chloe.ViewComponents.HeaderComponent
{    
    public class HeaderComponent : IHeaderComponent
    {
        public HeaderComponent()
        {
            this.ComponentType = ComponentType.Header;

            this.ViewName = "_Header";
        }

        public void Initialize()
        {

        }

        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }
    }
}
