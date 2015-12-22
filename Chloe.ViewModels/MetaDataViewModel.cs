using Chloe.ViewModels.Contracts;
using System.Collections.Generic;

namespace Chloe.ViewModels
{
    public class MetaDataViewModel: IMetaDataViewModel
    {
        public string Title { get; set; }

        public void Initialize(ICollection<IComponent> components)
        {
            
        }
    }
}
