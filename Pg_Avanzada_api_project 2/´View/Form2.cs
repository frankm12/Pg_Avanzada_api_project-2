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
            chart1.Dock = DockStyle.Fill;
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.IsLogarithmic = true;


            Series series = new Series("Criptomonedas")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = Color.MediumSlateBlue
            };

            // Solo tomar los primeros 10 (puedes cambiar el número)
            var topCryptos = cryptocurrencies.Take(10);

            foreach (var crypto in topCryptos)
            {
                series.Points.AddXY(crypto.name, crypto.current_price);
            }

            chart1.Series.Add(series);


            // Ajustes visuales
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart1.ChartAreas[0].AxisY.Title = "Precio en USD";
            chart1.ChartAreas[0].AxisX.Title = "Criptomonedas";
            // Ajustar área general del gráfico
            /*chart1.ChartAreas[0].Position.Auto = false;
            chart1.ChartAreas[0].Position.X = 0;
            chart1.ChartAreas[0].Position.Y = 0;
            chart1.ChartAreas[0].Position.Width = 90;
            chart1.ChartAreas[0].Position.Height = 90;*/

            // Opcional: quita márgenes automáticos del eje X
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;

        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDataRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
