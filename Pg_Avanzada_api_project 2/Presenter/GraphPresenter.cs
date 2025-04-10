using Pg_Avanzada_api_project_2.Interfaces;
using Pg_Avanzada_api_project_2.Model;
using Pg_Avanzada_api_project_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_Avanzada_api_project_2.Presenter
{
    public class GraphPresenter
    {
        private readonly IGraphView _view;
        private readonly CoinGeckoChartService _service;

        public GraphPresenter(IGraphView view, CoinGeckoChartService service)
        {
            _view = view;
            _service = service;

            _view.OnRequestChart += async (s, data) =>
            {
                await ObtenerDatos(data.id, data.intervalo);
            };
        }

        private async Task ObtenerDatos(string id, string intervalo)
        {
            try
            {
                var datos = await _service.GetMarketChartDataAsync(id, intervalo);
                _view.ShowColumnChart(datos);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Error: {ex.Message}");
            }
        }
    }
}
