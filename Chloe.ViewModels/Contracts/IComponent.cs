using System.Collections.Generic;

namespace Chloe.ViewModels.Contracts
{
    public interface IComponent
    {
        void Initialize();

        ComponentType ComponentType { get; set; }

        string ViewName { get; set; }
    }
}
