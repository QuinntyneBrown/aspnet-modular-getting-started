using Chloe.ViewModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Chloe.Metal.Filters
{
    public class MetaData: ActionFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            IPageViewModel pageViewModel = filterContext.Controller.ViewData.Model as IPageViewModel;
            IMetaDataViewModel metaDataViewModel = DependencyResolver.Current.GetService<IMetaDataViewModel>();
            metaDataViewModel.Initialize(pageViewModel.Components);
            filterContext.Controller.ViewData["MetaData"] = metaDataViewModel;
            base.OnResultExecuted(filterContext);
        }
    }
}
