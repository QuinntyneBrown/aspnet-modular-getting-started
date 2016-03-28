using Microsoft.Practices.Unity;

namespace Chloe.Web
{
    public abstract class WebViewPage<TModel>: System.Web.Mvc.WebViewPage<TModel>
    {
        public T Inject<T>()
        {
            return UnityConfig.Container.Resolve<T>();
        }
}
}