using Pg_Avanzada_api_project_2.Interfaces;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg_Avanzada_api_project_2._View
{
    public partial class Buscar_form : Form, ISearchView
    {
        public event EventHandler<string> OnSearchRequested;
        public Buscar_form()
        {
            InitializeComponent();
            var service = new CoinGeckoSearchService(new HttpClient());
            var presenter = new SearchPresenter(this, service);
            InicalizadorEnBlanco();
            btnBuscar.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
        public void DisplayResult(Root model)
        {
            lblId.Text = $"{model.id}";
            lblSymbol.Text = $"{model.symbol}";
            lblPrecio.Text = $"{model.current_price}";
            pictureBox1.Load(model.image); // Debes tener el control `PictureBox` agregado
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            var id = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(id))
                OnSearchRequested?.Invoke(this, id);
        }
        private void InicalizadorEnBlanco()
        {
            lblId.Text = "";
            lblPrecio.Text = "";
            lblSymbol.Text = "";
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                var id = txtBuscar.Text.Trim();
                if (!string.IsNullOrEmpty(id))
                    OnSearchRequested?.Invoke(this, id);
            }
        }
    }
}
