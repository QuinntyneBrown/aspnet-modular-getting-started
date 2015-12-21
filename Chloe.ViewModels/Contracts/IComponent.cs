using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chloe.ViewModels.Contracts
{
    public interface IComponent
    {
        void Initialize();

        ComponentType ComponentType { get; set; }

        string ViewName { get; set; }

        string ViewLocation { get; }

        Task InvokeAsync();
    }
}
