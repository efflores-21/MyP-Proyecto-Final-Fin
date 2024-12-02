namespace EduStats.Formularios
{
    partial class frmRegistroGDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroGDL));
            this.dgvGDL = new System.Windows.Forms.DataGridView();
            this.tsGDL = new System.Windows.Forms.ToolStrip();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLibro = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbCantidadDePrestaciones = new System.Windows.Forms.TextBox();
            this.tbPrestacionesPorLibro = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.DatosGDL = new System.Windows.Forms.GroupBox();
            this.ttGDL = new System.Windows.Forms.ToolTip(this.components);
            this.ofdGDL = new System.Windows.Forms.OpenFileDialog();
            this.sfdGDL = new System.Windows.Forms.SaveFileDialog();
            this.cmsGDL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.gbGDL2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGDL)).BeginInit();
            this.tsGDL.SuspendLayout();
            this.DatosGDL.SuspendLayout();
            this.cmsGDL.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGDL
            // 
            this.dgvGDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGDL.Location = new System.Drawing.Point(322, 58);
            this.dgvGDL.Name = "dgvGDL";
            this.dgvGDL.Size = new System.Drawing.Size(466, 380);
            this.dgvGDL.TabIndex = 2;
            this.dgvGDL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGDL_CellClick);
            this.dgvGDL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGDL_CellDoubleClick);
            // 
            // tsGDL
            // 
            this.tsGDL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargar,
            this.btnGuardar,
            this.btnImprimir,
            this.btnBuscar});
            this.tsGDL.Location = new System.Drawing.Point(0, 0);
            this.tsGDL.Name = "tsGDL";
            this.tsGDL.Size = new System.Drawing.Size(800, 25);
            this.tsGDL.TabIndex = 3;
            this.tsGDL.Text = "toolStrip1";
            // 
            // btnCargar
            // 
            this.btnCargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(23, 22);
            this.btnCargar.Text = "toolStripButton1";
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "toolStripButton2";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(23, 22);
            this.btnImprimir.Text = "toolStripButton3";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "toolStripButton4";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad De Prestaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prestaciones Por Libro";
            // 
            // tbLibro
            // 
            this.tbLibro.Location = new System.Drawing.Point(142, 41);
            this.tbLibro.Name = "tbLibro";
            this.tbLibro.Size = new System.Drawing.Size(100, 20);
            this.tbLibro.TabIndex = 3;
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(142, 67);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(100, 20);
            this.tbGenero.TabIndex = 4;
            // 
            // tbCantidadDePrestaciones
            // 
            this.tbCantidadDePrestaciones.Location = new System.Drawing.Point(142, 93);
            this.tbCantidadDePrestaciones.Name = "tbCantidadDePrestaciones";
            this.tbCantidadDePrestaciones.Size = new System.Drawing.Size(100, 20);
            this.tbCantidadDePrestaciones.TabIndex = 5;
            // 
            // tbPrestacionesPorLibro
            // 
            this.tbPrestacionesPorLibro.Location = new System.Drawing.Point(142, 121);
            this.tbPrestacionesPorLibro.Name = "tbPrestacionesPorLibro";
            this.tbPrestacionesPorLibro.Size = new System.Drawing.Size(100, 20);
            this.tbPrestacionesPorLibro.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(158, 147);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(142, 16);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 13;
            // 
            // DatosGDL
            // 
            this.DatosGDL.Controls.Add(this.tbID);
            this.DatosGDL.Controls.Add(this.label6);
            this.DatosGDL.Controls.Add(this.btnAgregar);
            this.DatosGDL.Controls.Add(this.tbPrestacionesPorLibro);
            this.DatosGDL.Controls.Add(this.tbCantidadDePrestaciones);
            this.DatosGDL.Controls.Add(this.tbGenero);
            this.DatosGDL.Controls.Add(this.tbLibro);
            this.DatosGDL.Controls.Add(this.label4);
            this.DatosGDL.Controls.Add(this.label3);
            this.DatosGDL.Controls.Add(this.label2);
            this.DatosGDL.Controls.Add(this.label1);
            this.DatosGDL.Location = new System.Drawing.Point(12, 58);
            this.DatosGDL.Name = "DatosGDL";
            this.DatosGDL.Size = new System.Drawing.Size(304, 180);
            this.DatosGDL.TabIndex = 1;
            this.DatosGDL.TabStop = false;
            this.DatosGDL.Text = "Datos";
            // 
            // ofdGDL
            // 
            this.ofdGDL.FileName = "openFileDialog1";
            // 
            // cmsGDL
            // 
            this.cmsGDL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEliminar});
            this.cmsGDL.Name = "cmsGDL";
            this.cmsGDL.Size = new System.Drawing.Size(154, 26);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(153, 22);
            this.btnEliminar.Text = "Quitar Registro";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbGDL2
            // 
            this.gbGDL2.Location = new System.Drawing.Point(322, 39);
            this.gbGDL2.Name = "gbGDL2";
            this.gbGDL2.Size = new System.Drawing.Size(466, 399);
            this.gbGDL2.TabIndex = 5;
            this.gbGDL2.TabStop = false;
            this.gbGDL2.Text = "Datos Registrados";
            // 
            // frmRegistroGDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsGDL);
            this.Controls.Add(this.dgvGDL);
            this.Controls.Add(this.DatosGDL);
            this.Controls.Add(this.gbGDL2);
            this.Name = "frmRegistroGDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroGDL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistroGDL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGDL)).EndInit();
            this.tsGDL.ResumeLayout(false);
            this.tsGDL.PerformLayout();
            this.DatosGDL.ResumeLayout(false);
            this.DatosGDL.PerformLayout();
            this.cmsGDL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGDL;
        private System.Windows.Forms.ToolStrip tsGDL;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLibro;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbCantidadDePrestaciones;
        private System.Windows.Forms.TextBox tbPrestacionesPorLibro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.GroupBox DatosGDL;
        private System.Windows.Forms.ToolTip ttGDL;
        private System.Windows.Forms.OpenFileDialog ofdGDL;
        private System.Windows.Forms.SaveFileDialog sfdGDL;
        private System.Windows.Forms.ContextMenuStrip cmsGDL;
        private System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private System.Windows.Forms.GroupBox gbGDL2;
    }
}