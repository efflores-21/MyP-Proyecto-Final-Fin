namespace EduStats.Formularios
{
    partial class frmRegsitroHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegsitroHD));
            this.ofdHD = new System.Windows.Forms.OpenFileDialog();
            this.tsHD = new System.Windows.Forms.ToolStrip();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.sfdHD = new System.Windows.Forms.SaveFileDialog();
            this.ttHD = new System.Windows.Forms.ToolTip(this.components);
            this.cmsHD = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.DatosHD = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.tbInfluencia = new System.Windows.Forms.TextBox();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.gbHD2 = new System.Windows.Forms.GroupBox();
            this.tsHD.SuspendLayout();
            this.cmsHD.SuspendLayout();
            this.DatosHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdHD
            // 
            this.ofdHD.FileName = "openFileDialog1";
            // 
            // tsHD
            // 
            this.tsHD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargar,
            this.btnGuardar,
            this.btnImprimir,
            this.btnBuscar});
            this.tsHD.Location = new System.Drawing.Point(0, 0);
            this.tsHD.Name = "tsHD";
            this.tsHD.Size = new System.Drawing.Size(800, 25);
            this.tsHD.TabIndex = 0;
            this.tsHD.Text = "toolStrip1";
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
            // cmsHD
            // 
            this.cmsHD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBorrar});
            this.cmsHD.Name = "contextMenuStrip1";
            this.cmsHD.Size = new System.Drawing.Size(154, 26);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(153, 22);
            this.btnBorrar.Text = "Quitar Registro";
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // DatosHD
            // 
            this.DatosHD.Controls.Add(this.btnAgregar);
            this.DatosHD.Controls.Add(this.tbMotivo);
            this.DatosHD.Controls.Add(this.tbInfluencia);
            this.DatosHD.Controls.Add(this.tbHoras);
            this.DatosHD.Controls.Add(this.label3);
            this.DatosHD.Controls.Add(this.label1);
            this.DatosHD.Controls.Add(this.label2);
            this.DatosHD.Location = new System.Drawing.Point(23, 42);
            this.DatosHD.Name = "DatosHD";
            this.DatosHD.Size = new System.Drawing.Size(321, 146);
            this.DatosHD.TabIndex = 1;
            this.DatosHD.TabStop = false;
            this.DatosHD.Text = "Datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(170, 109);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(159, 83);
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(100, 20);
            this.tbMotivo.TabIndex = 6;
            // 
            // tbInfluencia
            // 
            this.tbInfluencia.Location = new System.Drawing.Point(159, 52);
            this.tbInfluencia.Name = "tbInfluencia";
            this.tbInfluencia.Size = new System.Drawing.Size(100, 20);
            this.tbInfluencia.TabIndex = 5;
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(159, 19);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(100, 20);
            this.tbHoras.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Motivo Frecuente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Influencia (Alta, Media, Baja)";
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(350, 42);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.Size = new System.Drawing.Size(438, 396);
            this.dgvHD.TabIndex = 2;
            this.dgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellClick);
            this.dgvHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellDoubleClick);
            // 
            // gbHD2
            // 
            this.gbHD2.Location = new System.Drawing.Point(350, 27);
            this.gbHD2.Name = "gbHD2";
            this.gbHD2.Size = new System.Drawing.Size(438, 411);
            this.gbHD2.TabIndex = 3;
            this.gbHD2.TabStop = false;
            this.gbHD2.Text = "Datos Registrados";
            // 
            // frmRegsitroHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.DatosHD);
            this.Controls.Add(this.tsHD);
            this.Controls.Add(this.gbHD2);
            this.Name = "frmRegsitroHD";
            this.Text = "frmHorasDiarias";
            this.Load += new System.EventHandler(this.frmRegsitroHD_Load);
            this.tsHD.ResumeLayout(false);
            this.tsHD.PerformLayout();
            this.cmsHD.ResumeLayout(false);
            this.DatosHD.ResumeLayout(false);
            this.DatosHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdHD;
        private System.Windows.Forms.ToolStrip tsHD;
        private System.Windows.Forms.SaveFileDialog sfdHD;
        private System.Windows.Forms.ToolTip ttHD;
        private System.Windows.Forms.ContextMenuStrip cmsHD;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem btnBorrar;
        private System.Windows.Forms.GroupBox DatosHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.TextBox tbInfluencia;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.GroupBox gbHD2;
    }
}