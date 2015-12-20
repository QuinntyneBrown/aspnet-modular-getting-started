using Chloe.ViewModels.Contracts;
using System.Collections.Generic;
using System.Net.Http;

namespace Chloe.ViewModels
{
    public abstract class Page: IPage
    {
        public Page()
        {
            this.Components = new HashSet<IComponent>();
        }

        public string Title { get; set; }

        public ICollection<IComponent> Components { get; set; }

        public virtual void Initialize(Dictionary<string,string> routeParams)
        {
            foreach(var component in this.Components)
            {
                component.Initialize(routeParams);
            }
        }
    }
}
