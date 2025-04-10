namespace Pg_Avanzada_api_project_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.pn_dashboard = new System.Windows.Forms.Panel();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.pn_buscar = new System.Windows.Forms.Panel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.pn_graficos = new System.Windows.Forms.Panel();
            this.btn_graficos = new System.Windows.Forms.Button();
            this.pn_informacion = new System.Windows.Forms.Panel();
            this.btn_informacion = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.pn_dashboard.SuspendLayout();
            this.pn_buscar.SuspendLayout();
            this.pn_graficos.SuspendLayout();
            this.pn_informacion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.lbl_dashboard);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 59);
            this.panel1.TabIndex = 0;
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Font = new System.Drawing.Font("Franklin Gothic Book", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(68)))));
            this.lbl_dashboard.Location = new System.Drawing.Point(114, 10);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(178, 38);
            this.lbl_dashboard.TabIndex = 2;
            this.lbl_dashboard.Text = "Dashboard";
            // 
            // btn_menu
            // 
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.Location = new System.Drawing.Point(29, 10);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(49, 43);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menu.TabIndex = 1;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // pn_dashboard
            // 
            this.pn_dashboard.Controls.Add(this.btn_dashboard);
            this.pn_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_dashboard.Location = new System.Drawing.Point(3, 3);
            this.pn_dashboard.Name = "pn_dashboard";
            this.pn_dashboard.Size = new System.Drawing.Size(256, 85);
            this.pn_dashboard.TabIndex = 3;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.Image")));
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(256, 85);
            this.btn_dashboard.TabIndex = 2;
            this.btn_dashboard.Text = "  Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn_buscar
            // 
            this.pn_buscar.Controls.Add(this.btn_buscar);
            this.pn_buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_buscar.Location = new System.Drawing.Point(3, 94);
            this.pn_buscar.Name = "pn_buscar";
            this.pn_buscar.Size = new System.Drawing.Size(256, 85);
            this.pn_buscar.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.btn_buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(0, 0);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_buscar.Size = new System.Drawing.Size(256, 85);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // pn_graficos
            // 
            this.pn_graficos.Controls.Add(this.btn_graficos);
            this.pn_graficos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_graficos.Location = new System.Drawing.Point(3, 185);
            this.pn_graficos.Name = "pn_graficos";
            this.pn_graficos.Size = new System.Drawing.Size(256, 85);
            this.pn_graficos.TabIndex = 5;
            // 
            // btn_graficos
            // 
            this.btn_graficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.btn_graficos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_graficos.FlatAppearance.BorderSize = 0;
            this.btn_graficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_graficos.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_graficos.ForeColor = System.Drawing.Color.White;
            this.btn_graficos.Image = ((System.Drawing.Image)(resources.GetObject("btn_graficos.Image")));
            this.btn_graficos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_graficos.Location = new System.Drawing.Point(0, 0);
            this.btn_graficos.Name = "btn_graficos";
            this.btn_graficos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_graficos.Size = new System.Drawing.Size(256, 85);
            this.btn_graficos.TabIndex = 2;
            this.btn_graficos.Text = "Graficos";
            this.btn_graficos.UseVisualStyleBackColor = false;
            this.btn_graficos.Click += new System.EventHandler(this.btn_graficos_Click);
            // 
            // pn_informacion
            // 
            this.pn_informacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_informacion.Controls.Add(this.btn_informacion);
            this.pn_informacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_informacion.Location = new System.Drawing.Point(3, 276);
            this.pn_informacion.Name = "pn_informacion";
            this.pn_informacion.Size = new System.Drawing.Size(256, 85);
            this.pn_informacion.TabIndex = 6;
            // 
            // btn_informacion
            // 
            this.btn_informacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.btn_informacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_informacion.FlatAppearance.BorderSize = 0;
            this.btn_informacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_informacion.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_informacion.ForeColor = System.Drawing.Color.White;
            this.btn_informacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_informacion.Image")));
            this.btn_informacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_informacion.Location = new System.Drawing.Point(0, 0);
            this.btn_informacion.Name = "btn_informacion";
            this.btn_informacion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_informacion.Size = new System.Drawing.Size(256, 85);
            this.btn_informacion.TabIndex = 2;
            this.btn_informacion.Text = "    Información";
            this.btn_informacion.UseVisualStyleBackColor = false;
            this.btn_informacion.Click += new System.EventHandler(this.btn_informacion_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 7;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pn_dashboard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pn_informacion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pn_graficos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pn_buscar, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 548);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.pn_dashboard.ResumeLayout(false);
            this.pn_buscar.ResumeLayout(false);
            this.pn_graficos.ResumeLayout(false);
            this.pn_informacion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.Label lbl_dashboard;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel pn_dashboard;
        private System.Windows.Forms.Panel pn_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel pn_graficos;
        private System.Windows.Forms.Button btn_graficos;
        private System.Windows.Forms.Panel pn_informacion;
        private System.Windows.Forms.Button btn_informacion;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

