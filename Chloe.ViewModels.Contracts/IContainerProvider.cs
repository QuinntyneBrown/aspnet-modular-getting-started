using Microsoft.Practices.Unity;

namespace Chloe.ViewModels.Contracts
{
    public interface IContainerProvider
    {
        IUnityContainer GetContainer();
    }
}
