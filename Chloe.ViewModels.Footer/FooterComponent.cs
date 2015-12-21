using Chloe.ViewComponents.FooterComponent.Contracts;
using System;

namespace Chloe.ViewComponents.FooterComponent
{
    public class FooterComponent : IFooterComponent
    {
        public FooterComponent()
        {
            this.ComponentType = ComponentType.Footer;

            this.ViewName = "_Footer";
        }

        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }

        public void Initialize()
        {

        }
    }
}
