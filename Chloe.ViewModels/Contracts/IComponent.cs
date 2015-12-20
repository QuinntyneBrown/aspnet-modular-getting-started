using System.Collections.Generic;

namespace Chloe.ViewModels.Contracts
{
    public interface IComponent
    {
        void Initialize(Dictionary<string,string> routeParams = null);
    }
}
