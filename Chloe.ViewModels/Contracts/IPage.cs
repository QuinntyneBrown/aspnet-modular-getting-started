using System.Collections.Generic;

namespace Chloe.ViewModels.Contracts
{
    public interface IPage
    {
        ICollection<IComponent> Components { get; set; }

        void Initialize(Dictionary<string,string> routeParams);
    }
}
