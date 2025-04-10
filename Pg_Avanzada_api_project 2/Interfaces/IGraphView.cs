using Pg_Avanzada_api_project_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_Avanzada_api_project_2.Interfaces
{
    public interface IGraphView
    {
        event EventHandler<(string id, string intervalo)> OnRequestChart;
        void ShowChart(MarketChartDataModel model);
        void ShowError(string message);
        void ShowColumnChart(MarketChartDataModel model);
    }
}
