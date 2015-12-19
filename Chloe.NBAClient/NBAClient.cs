using Chloe.NBAClient.Contracts;
using Chloe.Dtos;
using System.Net.Http;
using Newtonsoft.Json;
using Chloe.Configuration.Contracts;

namespace Chloe.NBAClient
{
    public class NBAClient : INBAClient
    {
        public NBAClient(IAppConfigurationProvider appConfigurationProvider)
        {
            this.appConfiguration = appConfigurationProvider.GetAppConfiguration();
        }

        public AllPlayersResponseDto GetAllPlayers()
        {
            HttpClient client = new HttpClient();
            var result = client.GetAsync(string.Format(
                "{0}/stats/commonallplayers?IsOnlyCurrentSeason=1&LeagueID=00&Season=2015-16", 
                this.appConfiguration.BaseUri)
                ).Result;
            string json = result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<AllPlayersResponseDto>(json);
        }

        protected readonly IAppConfiguration appConfiguration;
    }
}
