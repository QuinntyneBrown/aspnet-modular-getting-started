using System.Collections.Generic;

namespace Chloe.ViewModels.Contracts
{
    public interface IPageViewModel
    {
        ICollection<IComponent> Components { get; set; }

        void Initialize();

        IComponent GetComponentByName(string name);
    }
}
