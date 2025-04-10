using Pg_Avanzada_api_project_2._View;
using Pg_Avanzada_api_project_2.Model;
using Pg_Avanzada_api_project_2.Presenter;
using Pg_Avanzada_api_project_2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pg_Avanzada_api_project_2
{
    public partial class Form2 : Form, ICryptocurrencyView, ITrendingCryptocurrencyView
    {
        public event EventHandler LoadDataRequested;
        public event EventHandler LoadTrendingDataRequested;
        public Form2()
        {
            InitializeComponent();
            ConfigureChart();
            var apiService = new CoinGeckoApiService(new HttpClient());
            var presenter = new CryptocurrencyPresenter(this, apiService);
            ConfigureChartTrending();
            var trendingService = new CoinGeckoTrendingService(new HttpClient());
            var trendingPresenter = new TrendingCryptocurrencyPresenter(this, trendingService);
        }

        private void ConfigureChartTrending()
        {
            // Limpiar todo antes de configurar
            chart2.Series.Clear();
            chart2.Legends.Clear();
            chart2.ChartAreas.Clear();

            // Crear y configurar área
            ChartArea chartArea = new ChartArea("TrendingArea");

            // Eje Y logarítmico
            chartArea.AxisY.IsLogarithmic = true;
            chartArea.AxisY.Title = "Precio en USD";

            // Eje X con nombres inclinados
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.Title = "Criptomonedas";

            // Autoajuste
            chartArea.Position.Auto = true;

            chart2.ChartAreas.Add(chartArea);
            chart2.Dock = DockStyle.Fill;

        }
        private void ConfigureChart()
        {
            // Configuración básica del Chart (si no se hizo en el diseñador)
            chart1.ChartAreas.Add(new ChartArea());
        }
        public void DisplayTrendingCryptocurrencies(List<TrendingCryptocurrencyModel> cryptocurrencies)
        {
            if (cryptocurrencies == null || cryptocurrencies.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar.");
                return;
            }

            chart2.ChartAreas.Clear();
            chart2.ChartAreas.Add(new ChartArea("ChartArea1"));
            var series = new Series("Criptomonedas")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                ChartArea = "ChartArea1",
                Color = Color.Gold
            };

            var topTrending = cryptocurrencies.Take(5);

            foreach (var crypto in topTrending)
            {
                if (crypto.Price.HasValue)
                {
                    series.Points.AddXY(crypto.Name, crypto.Price.Value);
                }
            }


            chart2.Series.Add(series);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DisplayCryptocurrencies(List<CryptocurrencyModel> cryptocurrencies)
        {
            if (cryptocurrencies == null || cryptocurrencies.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar.");
                return;
            }

            // Ajustar el Chart al contenedor
            chart1.Dock = DockStyle.Fill;
            chart1.Series.Clear();
            chart1.Legends.Clear(); // Eliminar la leyenda si no es necesaria
            chart1.ChartAreas.Clear(); // Limpiar áreas previas

            // Crear nueva área de gráfico
            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisY.IsLogarithmic = true;

            // Estilo del eje X
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Angle = -45;
            //chartArea.AxisX.Title = "Criptomonedas";

            // Estilo del eje Y
            //chartArea.AxisY.Title = "Precio en USD";

            // Margen automático
            chartArea.Position.Auto = true;

            chart1.ChartAreas.Add(chartArea);

            // Crear serie de datos
            Series series = new Series("Criptomonedas")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = Color.Gold
            };

            var topCryptos = cryptocurrencies.Take(10);
            foreach (var crypto in topCryptos)
            {
                series.Points.AddXY(crypto.name, crypto.current_price);
            }

            chart1.Series.Add(series);
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDataRequested?.Invoke(this, EventArgs.Empty);
            LoadTrendingDataRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
