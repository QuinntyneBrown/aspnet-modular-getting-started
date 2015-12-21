using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.ViewComponents.Contracts
{
    public interface IMetaDataViewModel
    {
        void Initialize(ICollection<IComponent> components);

        string Title { get; set; }
    }
}
