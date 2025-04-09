using Newtonsoft.Json;
using Pg_Avanzada_api_project_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pg_Avanzada_api_project_2.Services
{
    public class CoinGeckoTrendingService
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://api.coingecko.com/api/v3/search/trending";

        public CoinGeckoTrendingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; MyApp/1.0)");
        }

        public async Task<List<TrendingCryptocurrencyModel>> GetTrendingCryptocurrenciesAsync()
        {
            var response = await _httpClient.GetStringAsync(ApiUrl);
            var root = JsonConvert.DeserializeObject<TrendingRoot>(response);
            var trendingCryptos = new List<TrendingCryptocurrencyModel>();

            foreach (var item in root.coins)
            {
                trendingCryptos.Add(new TrendingCryptocurrencyModel
                {
                    Name = item.Item.Name,
                    Price = item.Item.Data?.Price
                });
            }

            return trendingCryptos;
        }
    }
}
