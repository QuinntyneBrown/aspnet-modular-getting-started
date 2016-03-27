using Chloe.ViewModels.Contracts;
using Microsoft.Practices.Unity;

namespace Chloe.Web
{
    public class ContainerProvider: IContainerProvider
    {
        public IUnityContainer GetContainer()
        {
            return UnityConfig.Container;
        }
    }
}