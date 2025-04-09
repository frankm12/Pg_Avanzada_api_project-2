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
    public partial class Form2 : Form, ICryptocurrencyView
    {
        public event EventHandler LoadDataRequested;
        public Form2()
        {
            InitializeComponent();
            ConfigureChart();
            var apiService = new CoinGeckoApiService(new HttpClient());
            var presenter = new CryptocurrencyPresenter(this, apiService);
        }

        private void ConfigureChart()
        {
            // Configuración básica del Chart (si no se hizo en el diseñador)
            chart1.ChartAreas.Add(new ChartArea());
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
            chartArea.AxisX.Title = "Criptomonedas";

            // Estilo del eje Y
            chartArea.AxisY.Title = "Precio en USD";

            // Margen automático
            chartArea.Position.Auto = true;

            // Alternativa: Forzar 100% del área
            //chartArea.Position.Auto = false;
            //chartArea.Position.X = 0;
            //chartArea.Position.Y = 0;
            //chartArea.Position.Width = 100;
            //chartArea.Position.Height = 100;

            chart1.ChartAreas.Add(chartArea);

            // Crear serie de datos
            Series series = new Series("Criptomonedas")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = Color.MediumSlateBlue
            };

            var topCryptos = cryptocurrencies.Take(10);
            foreach (var crypto in topCryptos)
            {
                series.Points.AddXY(crypto.name, crypto.current_price);
            }

            chart1.Series.Add(series);
        }


        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDataRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
