using Chloe.NBAClient.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chloe.Dtos;
using System.Net.Http;
using Newtonsoft.Json;

namespace Chloe.NBAClient
{
    public class NBAClient : INBAClient
    {
        public AllPlayersResponseDto GetAllPlayers()
        {
            HttpClient client = new HttpClient();
            var result = client.GetAsync("http://stats.nba.com/stats/commonallplayers?IsOnlyCurrentSeason=1&LeagueID=00&Season=2015-16").Result;
            string json = result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<AllPlayersResponseDto>(json);
        }
    }
}
