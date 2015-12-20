using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Metal.Contracts
{
    public interface IRouteParamsProvider
    {
        Dictionary<string, string> Get();

        void Set(string key, string value);
    }
}
