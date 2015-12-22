using Chloe.ViewModels.Contracts;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;

namespace Chloe.ViewModels
{
    public class PageViewModel: IPageViewModel
    {
        public PageViewModel()
        {
            this.Components = new HashSet<IComponent>();
        }

        public string Title { get; set; }

        public ICollection<IComponent> Components { get; set; }

        public virtual void Initialize()
        {
            List<Task> tasks = new List<Task>();

            foreach(var component in this.Components)
            {
                tasks.Add(component.InvokeAsync());
            }

            Task.WaitAll(tasks.ToArray());
        }

        public IComponent GetComponentByName(string name)
        {
            return this.Components.Single(x => x.ViewName == name);
        }

        public ICollection<IComponent> GetBodyComponents()
        {
            return this.Components.Where(x => x.ViewName != "Header" && x.ViewName != "Footer").ToList();            
        }
    }
}
