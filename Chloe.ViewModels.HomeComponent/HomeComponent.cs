using Chloe.ViewComponents.HomeComponent.Contracts;
using System;
using Chloe.ViewModels;
using System.Threading.Tasks;

namespace Chloe.ViewComponents.HomeComponent
{
    public class HomeComponent : IHomeComponent
    {
        public HomeComponent()
        {
            this.ComponentType = ComponentType.Home;
            this.ViewName = "Home";
        }

        public Task InvokeAsync()
        {
            return Task.Run(() => { return new { }; });
        }

        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }

        public string ViewLocation { get {
                return string.Format("Components/_{0}", this.ViewName);
            } }
    }
}
