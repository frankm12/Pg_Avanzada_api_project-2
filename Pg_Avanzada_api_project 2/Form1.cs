using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg_Avanzada_api_project_2
{
    public partial class Form1 : Form
    {
        Form2 dashboard;
        bool sidebarExpand = true;
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Width = 69;
            AbrirDashboard();
        }
        public void AbrirDashboard()
        {
            btn_buscar.Text = "";
            btn_dashboard.Text = "";
            btn_graficos.Text = "";
            btn_informacion.Text = "";
            if (dashboard == null)
            {
                dashboard = new Form2();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                tableLayoutPanel1.Width += 5;
                if (tableLayoutPanel1.Width >= 262)
                {
                    sidebarExpand = false;
                    menuTransition.Stop();
                    pn_dashboard.Width = tableLayoutPanel1.Width;
                    pn_buscar.Width = tableLayoutPanel1.Width;
                    pn_graficos.Width = tableLayoutPanel1.Width;
                    pn_informacion.Width = tableLayoutPanel1.Width;
                    btn_buscar.Text = "Buscar";
                    btn_dashboard.Text = "Dashboard";
                    btn_graficos.Text = "Graficos";
                    btn_informacion.Text = "Información";
                }

            } 
            else
            {
                btn_buscar.Text = "";
                btn_dashboard.Text = "";
                btn_graficos.Text = "";
                btn_informacion.Text = "";
                tableLayoutPanel1.Width -= 5;
                if (tableLayoutPanel1.Width <= 69)
                {

                    sidebarExpand = true;
                    menuTransition.Stop();

                    pn_dashboard.Width = tableLayoutPanel1.Width;
                    pn_buscar.Width = tableLayoutPanel1.Width;
                    pn_graficos.Width = tableLayoutPanel1.Width;
                    pn_informacion.Width = tableLayoutPanel1.Width;

                }

            }

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirDashboard();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }
    }
}
