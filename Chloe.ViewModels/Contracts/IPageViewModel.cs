using System.Collections.Generic;

namespace Chloe.ViewComponents.Contracts
{
    public interface IPageViewModel
    {
        ICollection<IComponent> Components { get; set; }

        void Initialize();
    }
}
