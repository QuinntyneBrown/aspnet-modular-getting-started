using Chloe.ViewModels;
using Chloe.ViewModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Services.Contracts
{
    public interface IChloeService
    {
        IHome GetHomePageViewModel();
    }
}
