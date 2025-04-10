using Pg_Avanzada_api_project_2.Interfaces;
using Pg_Avanzada_api_project_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_Avanzada_api_project_2.Presenter
{
    public class SearchPresenter
    {
        private readonly ISearchView _view;
        private readonly CoinGeckoSearchService _service;

        public SearchPresenter(ISearchView view, CoinGeckoSearchService service)
        {
            _view = view;
            _service = service;

            _view.OnSearchRequested += async (s, id) => await BuscarCripto(id);
        }

        private async Task BuscarCripto(string id)
        {
            try
            {
                var crypto = await _service.GetCryptocurrencyByIdAsync(id.ToLower());
                _view.DisplayResult(crypto);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Error al buscar: {ex.Message}");
            }
        }
    }

}
