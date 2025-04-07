using Pg_Avanzada_api_project_2._View;
using Pg_Avanzada_api_project_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_Avanzada_api_project_2.Presenter
{
    public class CryptocurrencyPresenter
    {
        private readonly ICryptocurrencyView _view;
        private readonly IApiService _apiService;

        public CryptocurrencyPresenter(ICryptocurrencyView view, IApiService apiService)
        {
            _view = view;
            _apiService = apiService;
            _view.LoadDataRequested += OnLoadDataRequested;
        }

        private async void OnLoadDataRequested(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var cryptocurrencies = await _apiService.GetCryptocurrenciesAsync();
                _view.DisplayCryptocurrencies(cryptocurrencies);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Error al cargar datos: {ex.Message}");
            }
        }
    }
}
