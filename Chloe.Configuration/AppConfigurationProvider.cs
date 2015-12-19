using Chloe.Configuration.Contracts;
using System.Configuration;


namespace Chloe.Configuration
{
    public class AppConfigurationProvider : IAppConfigurationProvider
    {
        public IAppConfiguration GetAppConfiguration()
        {
            return ConfigurationManager.GetSection("appConfiguration") as AppConfiguration;
        }
    }
}
