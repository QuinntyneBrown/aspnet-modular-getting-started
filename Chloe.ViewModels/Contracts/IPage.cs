using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.ViewModels.Contracts
{
    public interface IPage
    {
        ICollection<IComponent> Components { get; set; }

        void Initialize();
    }
}
