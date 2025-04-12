using Pg_Avanzada_api_project_2._View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pg_Avanzada_api_project_2
{
    public partial class Form1 : Form
    {
        Form2 dashboard;
        Buscar_form buscar_Form;
        GraficosForm graficos_Form;
        Informacion_form informacion_form;


        bool sidebarExpandida = false; // empieza cerrada

        public Form1()
        {
            InitializeComponent();

            // Configuración inicial del sidebar
            tableLayoutPanel1.Width = 90;
            OcultarTextoBotones();
            menuTransition.Interval = 1;
            this.WindowState = FormWindowState.Maximized;

            // Mostrar el dashboard al iniciar
            AbrirDashboard();
            EstablecerBotonActivo(btn_dashboard);
        }
        private void EstablecerBotonActivo(Button botonActivo)
        {
            // Lista de todos los botones del menú
            var botones = new List<Button> { btn_dashboard, btn_buscar, btn_graficos, btn_informacion };

            foreach (var boton in botones)
            {
                if (boton == botonActivo)
                {
                    boton.BackColor = Color.Black; // Botón activo en negro
                    boton.ForeColor = Color.White; // Texto blanco para contraste
                }
                else
                {
                    boton.BackColor = Color.FromArgb(70, 72, 74); 
                    boton.ForeColor = Color.Gainsboro;
                }
            }
        }
        private void MostrarTextoBotones()
        {
            btn_buscar.Text = "Buscar";
            btn_dashboard.Text = "Dashboard";
            btn_graficos.Text = "Gráficos";
            btn_informacion.Text = "Información";
        }
        private void OcultarTextoBotones()
        {
            btn_buscar.Text = "";
            btn_dashboard.Text = "";
            btn_graficos.Text = "";
            btn_informacion.Text = "";
        }

        public void AbrirDashboard()
        {
            if (dashboard == null)
            {
                dashboard = new Form2();
                dashboard.FormClosed += (s, e) => dashboard = null;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
            lbl_dashboard.Text = "Dashboard";
        }
        public void AbrirBuscar()
        {
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
            lbl_dashboard.Text = "Buscar";
        }

        public void AbrirInformacion()
        {
            if (informacion_form == null)
            {
                informacion_form = new Informacion_form();
                informacion_form.FormClosed += (s, e) => informacion_form = null;
                informacion_form.MdiParent = this;
                informacion_form.Dock = DockStyle.Fill;
                informacion_form.Show();
            }
            else
            {
                informacion_form.Activate();
            }
            lbl_dashboard.Text = "Información";
        }

        public void AbrirGraficos()
        {
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
            lbl_dashboard.Text = "Graficos";

        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {

            int velocidad = 40;
            int anchoMax = 262;
            int anchoMin = 90;

            if (sidebarExpandida)
            {
                tableLayoutPanel1.Width -= velocidad;
                if (tableLayoutPanel1.Width <= anchoMin)
                {
                    menuTransition.Stop();
                    sidebarExpandida = false;
                    tableLayoutPanel1.Width = anchoMin;
                    OcultarTextoBotones();
                }
            }
            else
            {
                tableLayoutPanel1.Width += velocidad;
                if (tableLayoutPanel1.Width >= anchoMax)
                {
                    menuTransition.Stop();
                    sidebarExpandida = true;
                    tableLayoutPanel1.Width = anchoMax;
                    MostrarTextoBotones();
                }
            }

            // Actualizar paneles laterales
            pn_dashboard.Width = tableLayoutPanel1.Width;
            pn_buscar.Width = tableLayoutPanel1.Width;
            pn_graficos.Width = tableLayoutPanel1.Width;
            pn_informacion.Width = tableLayoutPanel1.Width;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (!menuTransition.Enabled)
            {
                // Ocultar texto antes de contraer
                if (sidebarExpandida)
                    OcultarTextoBotones();

                menuTransition.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirDashboard();
            EstablecerBotonActivo(btn_dashboard);
        } 


        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e) 
        {
            AbrirBuscar();
            EstablecerBotonActivo(btn_buscar);
        } 

        private void btn_graficos_Click(object sender, EventArgs e) 
        {
            AbrirGraficos();
            EstablecerBotonActivo(btn_graficos);
        } 

        private void btn_informacion_Click(object sender, EventArgs e)
        {
            AbrirInformacion();
            EstablecerBotonActivo(btn_informacion);
        }

    }
}
