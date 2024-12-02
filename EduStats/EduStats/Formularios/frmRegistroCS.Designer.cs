namespace EduStats.Formularios
{
    partial class frmRegistroCS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroCS));
            this.ofdCS = new System.Windows.Forms.OpenFileDialog();
            this.sfdCS = new System.Windows.Forms.SaveFileDialog();
            this.cmsCS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCS = new System.Windows.Forms.ToolStrip();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.ttCS = new System.Windows.Forms.ToolTip(this.components);
            this.gbDatosCS = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbNumeroDeLibrosSolicitados = new System.Windows.Forms.TextBox();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.tbMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRegistrosCS = new System.Windows.Forms.GroupBox();
            this.dgvCS = new System.Windows.Forms.DataGridView();
            this.cmsCS.SuspendLayout();
            this.tsCS.SuspendLayout();
            this.gbDatosCS.SuspendLayout();
            this.gbRegistrosCS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCS)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdCS
            // 
            this.ofdCS.FileName = "openFileDialog1";
            // 
            // cmsCS
            // 
            this.cmsCS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitarRegistroToolStripMenuItem});
            this.cmsCS.Name = "cmsCS";
            this.cmsCS.Size = new System.Drawing.Size(154, 26);
            // 
            // quitarRegistroToolStripMenuItem
            // 
            this.quitarRegistroToolStripMenuItem.Name = "quitarRegistroToolStripMenuItem";
            this.quitarRegistroToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.quitarRegistroToolStripMenuItem.Text = "Quitar Registro";
            this.quitarRegistroToolStripMenuItem.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // tsCS
            // 
            this.tsCS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargar,
            this.btnGuardar,
            this.btnImprimir,
            this.btnBuscar});
            this.tsCS.Location = new System.Drawing.Point(0, 0);
            this.tsCS.Name = "tsCS";
            this.tsCS.Size = new System.Drawing.Size(800, 25);
            this.tsCS.TabIndex = 1;
            this.tsCS.Text = "toolStrip1";
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
            // gbDatosCS
            // 
            this.gbDatosCS.Controls.Add(this.btnAgregar);
            this.gbDatosCS.Controls.Add(this.tbNumeroDeLibrosSolicitados);
            this.gbDatosCS.Controls.Add(this.tbCarrera);
            this.gbDatosCS.Controls.Add(this.tbMes);
            this.gbDatosCS.Controls.Add(this.label3);
            this.gbDatosCS.Controls.Add(this.label2);
            this.gbDatosCS.Controls.Add(this.label1);
            this.gbDatosCS.Location = new System.Drawing.Point(12, 44);
            this.gbDatosCS.Name = "gbDatosCS";
            this.gbDatosCS.Size = new System.Drawing.Size(321, 159);
            this.gbDatosCS.TabIndex = 2;
            this.gbDatosCS.TabStop = false;
            this.gbDatosCS.Text = "Datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(168, 97);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbNumeroDeLibrosSolicitados
            // 
            this.tbNumeroDeLibrosSolicitados.Location = new System.Drawing.Point(157, 71);
            this.tbNumeroDeLibrosSolicitados.Name = "tbNumeroDeLibrosSolicitados";
            this.tbNumeroDeLibrosSolicitados.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroDeLibrosSolicitados.TabIndex = 5;
            // 
            // tbCarrera
            // 
            this.tbCarrera.Location = new System.Drawing.Point(157, 45);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(100, 20);
            this.tbCarrera.TabIndex = 4;
            // 
            // tbMes
            // 
            this.tbMes.Location = new System.Drawing.Point(157, 19);
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(100, 20);
            this.tbMes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carrera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero De Libros Solicitados";
            // 
            // gbRegistrosCS
            // 
            this.gbRegistrosCS.Controls.Add(this.dgvCS);
            this.gbRegistrosCS.Location = new System.Drawing.Point(339, 28);
            this.gbRegistrosCS.Name = "gbRegistrosCS";
            this.gbRegistrosCS.Size = new System.Drawing.Size(449, 410);
            this.gbRegistrosCS.TabIndex = 3;
            this.gbRegistrosCS.TabStop = false;
            this.gbRegistrosCS.Text = "DatosRegistrados";
            // 
            // dgvCS
            // 
            this.dgvCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCS.Location = new System.Drawing.Point(3, 16);
            this.dgvCS.Name = "dgvCS";
            this.dgvCS.Size = new System.Drawing.Size(443, 391);
            this.dgvCS.TabIndex = 0;
            this.dgvCS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCS_CellClick);
            this.dgvCS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCS_CellDoubleClick);
            // 
            // frmRegistroCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRegistrosCS);
            this.Controls.Add(this.gbDatosCS);
            this.Controls.Add(this.tsCS);
            this.Name = "frmRegistroCS";
            this.Text = "frmRegistroCS";
            this.Load += new System.EventHandler(this.frmRegsitroCS_Load);
            this.cmsCS.ResumeLayout(false);
            this.tsCS.ResumeLayout(false);
            this.tsCS.PerformLayout();
            this.gbDatosCS.ResumeLayout(false);
            this.gbDatosCS.PerformLayout();
            this.gbRegistrosCS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdCS;
        private System.Windows.Forms.SaveFileDialog sfdCS;
        private System.Windows.Forms.ContextMenuStrip cmsCS;
        private System.Windows.Forms.ToolStrip tsCS;
        private System.Windows.Forms.ToolTip ttCS;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.GroupBox gbDatosCS;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbNumeroDeLibrosSolicitados;
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRegistrosCS;
        private System.Windows.Forms.DataGridView dgvCS;
        private System.Windows.Forms.ToolStripMenuItem quitarRegistroToolStripMenuItem;
    }
}