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
    public class CoinGeckoSearchService
    {
        private readonly HttpClient _httpClient;

        public CoinGeckoSearchService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0");
        }

        public async Task<Root> GetCryptocurrencyByIdAsync(string id)
        {
            var url = $"https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&ids={id}";

            var response = await _httpClient.GetStringAsync(url);

            var list = JsonConvert.DeserializeObject<List<Root>>(response);

            if (list != null && list.Count > 0)
            {
                return list[0];
            }

            throw new Exception("Criptomoneda no encontrada.");
        }
    }
}
