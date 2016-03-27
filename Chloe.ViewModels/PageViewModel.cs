using Chloe.ViewModels.Contracts;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Chloe.ViewModels
{
    public class PageViewModel: IPageViewModel
    {
        public PageViewModel(IContainerProvider containerProvider)
        {
            this.Components = new HashSet<IComponent>();
            this.container = containerProvider.GetContainer();
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

        public T Inject<T>()
        {

            return container.Resolve<T>();
        }

        public IUnityContainer container;
    }
}
