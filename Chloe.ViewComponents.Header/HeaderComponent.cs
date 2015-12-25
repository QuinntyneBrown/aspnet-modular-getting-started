using Chloe.NBAClient.Contracts;
using Chloe.ViewComponents.HeaderComponent.Contracts;
using Chloe.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chloe.ViewComponents.HeaderComponent
{    
    public class HeaderComponent : IHeaderComponent
    {
        public HeaderComponent(INBAClient client)
        {
            this.ComponentType = ComponentType.Header;
            this.ViewName = "Header";
            this.Links = new HashSet<Link>();
            this.client = client;
        }

        public Task InvokeAsync()
        {
            return Task.Run(() => { return new { }; });            
        }

        public ICollection<Link> Links { get; set; }

        public ComponentType ComponentType { get; set; }

        public string ViewName { get; set; }

        public string ViewLocation { get { return string.Format("Components/_{0}",this.ViewName); } }

        protected readonly INBAClient client;
    }
}
