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
        [ConfigurationProperty("useExcelDataSource", IsRequired = true)]
        public bool UseExcelDataSource
        {
            get { return (bool)this["useExcelDataSource"]; }
            set { this["useExcelDataSource"] = value; }
        }
    }
}
