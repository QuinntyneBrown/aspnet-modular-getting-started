using System.Net.Http;
using System.Threading.Tasks;

namespace Chloe.Http
{
    public class HttpClientHelper
    {
        public static Task<T> GetAsync<T>(string uri)
        {
            return new HttpClient().GetAsync(uri).Result.Content.ReadAsAsync<T>();
        }
    }
}
