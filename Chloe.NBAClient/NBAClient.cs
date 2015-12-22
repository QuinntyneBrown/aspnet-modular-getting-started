using Chloe.Configuration.Contracts;
using Chloe.Dtos;
using Chloe.Http;
using Chloe.NBAClient.Contracts;
using System.Threading.Tasks;

namespace Chloe.NBAClient
{
    public class NBAClient : INBAClient
    {
        public NBAClient(IAppConfigurationProvider appConfigurationProvider)
        {
            this.appConfiguration = appConfigurationProvider.GetAppConfiguration();
        }
        
        public Task<AllPlayersResponseDto> GetAllPlayersAsync()
        {
            string uri = string.Format(
                    "{0}/stats/commonallplayers?IsOnlyCurrentSeason=1&LeagueID=00&Season=2015-16",
                    this.appConfiguration.BaseUri);

            return HttpClientHelper.GetAsync<AllPlayersResponseDto>(uri);
           
        }

        protected readonly IAppConfiguration appConfiguration;
    }
}
