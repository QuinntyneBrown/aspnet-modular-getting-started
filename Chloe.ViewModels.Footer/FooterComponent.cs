using Chloe.ViewComponents.FooterComponent.Contracts;
using Chloe.ViewModels;
using System;
using System.Threading.Tasks;


namespace Chloe.ViewComponents.FooterComponent
{
    public class FooterComponent : IFooterComponent
    {
        public FooterComponent()
        {
            this.ComponentType = ComponentType.Footer;

            this.ViewName = "Footer";
        }

        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }

        public void Initialize()
        {

        }

        public Task InvokeAsync()
        {            
            return Task.Factory.StartNew<int>(() => {return 1; });
        }

        public string ViewLocation { get { return string.Format("Components/_{0}", this.ViewName); } }
    }
}
