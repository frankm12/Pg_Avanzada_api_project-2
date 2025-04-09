using Pg_Avanzada_api_project_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg_Avanzada_api_project_2.Presenter
{
    public class TrendingCryptocurrencyPresenter
    {
        private readonly ITrendingCryptocurrencyView _view;
        private readonly CoinGeckoTrendingService _service;

        public TrendingCryptocurrencyPresenter(ITrendingCryptocurrencyView view, CoinGeckoTrendingService service)
        {
            _view = view;
            _service = service;
            _view.LoadTrendingDataRequested += OnLoadTrendingDataRequested;
        }

        private async void OnLoadTrendingDataRequested(object sender, EventArgs e)
        {
            await LoadTrendingDataAsync();
        }

        private async Task LoadTrendingDataAsync()
        {
            try
            {
                var cryptocurrencies = await _service.GetTrendingCryptocurrenciesAsync();
                _view.DisplayTrendingCryptocurrencies(cryptocurrencies);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Error al cargar datos: {ex.Message}");
            }
        }
    }
}
