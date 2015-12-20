using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Metal.Contracts
{
    public interface IRouteParamsProvider
    {
        Dictionary<string, object> Get();

        void Set(string key, object value);
    }
}
