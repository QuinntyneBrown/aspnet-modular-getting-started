using Chloe.Configuration.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Configuration
{
    public class AppConfiguration : ConfigurationSection, IAppConfiguration
    {
        [ConfigurationProperty("baseUri", IsRequired = true)]
        public string BaseUri
        {
            get { return (string)this["baseUri"]; }
            set { this["baseUri"] = value; }
        }
    }
}
