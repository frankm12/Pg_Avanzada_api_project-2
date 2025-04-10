using Pg_Avanzada_api_project_2._View;
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
        Buscar_form buscar_Form;
        GraficosForm graficos_Form;
        bool sidebarExpand = true;
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Width = 90;
            //llamamos el metodo dashboard para que se abra cuando se inicie el programa
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
        public void AbrirBuscar()
        {
            btn_buscar.Text = "";
            btn_dashboard.Text = "";
            btn_graficos.Text = "";
            btn_informacion.Text = "";

            if (buscar_Form == null)
            {
                buscar_Form = new Buscar_form();
                buscar_Form.FormClosed += (s, e) => buscar_Form = null; 
                buscar_Form.MdiParent = this;
                buscar_Form.Dock = DockStyle.Fill;
                buscar_Form.Show();
            }
            else
            {
                buscar_Form.Activate(); 
            }
        }

        public void AbrirGraficos()
        {
            btn_buscar.Text = "";
            btn_dashboard.Text = "";
            btn_graficos.Text = "";
            btn_informacion.Text = "";

            if (graficos_Form == null)
            {
                graficos_Form = new GraficosForm();
                graficos_Form.FormClosed += (s, e) => graficos_Form = null;
                graficos_Form.MdiParent = this;
                graficos_Form.Dock = DockStyle.Fill;
                graficos_Form.Show();
            }
            else
            {
                graficos_Form.Activate();
            }
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {

            
            if (sidebarExpand)
            {
                tableLayoutPanel1.Width += 10;
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
                tableLayoutPanel1.Width -= 10;
                if (tableLayoutPanel1.Width <= 90)

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

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            AbrirBuscar();
        }

        private void btn_graficos_Click(object sender, EventArgs e)
        {
            AbrirGraficos();
        }
    }
}
