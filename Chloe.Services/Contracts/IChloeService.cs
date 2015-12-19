using Chloe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Services.Contracts
{
    public interface IChloeService
    {
        Home GetHomePageViewModel();
    }
}
