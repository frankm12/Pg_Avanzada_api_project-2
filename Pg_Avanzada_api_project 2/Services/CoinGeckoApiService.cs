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
    public class CoinGeckoApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd";

        public CoinGeckoApiService(HttpClient httpClient)
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; MyApp/1.0)");
        }

        public async Task<List<CryptocurrencyModel>> GetCryptocurrenciesAsync()
        {
            try
            {
                // Usa HttpResponseMessage en lugar de GetStringAsync
                HttpResponseMessage response = await _httpClient.GetAsync(ApiUrl);

                if (!response.IsSuccessStatusCode)
                {
                    string errorBody = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Error HTTP: {response.StatusCode} - {errorBody}");
                }

                string json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<CryptocurrencyModel>>(json);

                return data;
            }
            catch (Exception ex)
            {
                // Aquí capturamos cualquier excepción y la lanzamos de nuevo para que el Presenter pueda mostrarla
                throw new Exception($"Ocurrió un error al obtener los datos del API: {ex.Message}", ex);
            }
        }
    }
}
