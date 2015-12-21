using Chloe.ViewModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
