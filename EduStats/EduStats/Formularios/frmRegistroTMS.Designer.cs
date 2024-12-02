namespace EduStats.Formularios
{
    partial class frmRegistroTMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroTMS));
            this.ofdTMS = new System.Windows.Forms.OpenFileDialog();
            this.sfdTMS = new System.Windows.Forms.SaveFileDialog();
            this.cmsTMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTMS = new System.Windows.Forms.ToolStrip();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.ttTMS = new System.Windows.Forms.ToolTip(this.components);
            this.gbTMS = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbMes = new System.Windows.Forms.TextBox();
            this.tbPrestacionesPorLibro = new System.Windows.Forms.TextBox();
            this.tbLibro = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosRegistrados = new System.Windows.Forms.GroupBox();
            this.dgvTMS = new System.Windows.Forms.DataGridView();
            this.cmsTMS.SuspendLayout();
            this.tsTMS.SuspendLayout();
            this.gbTMS.SuspendLayout();
            this.gbDatosRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTMS)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdTMS
            // 
            this.ofdTMS.FileName = "openFileDialog1";
            // 
            // cmsTMS
            // 
            this.cmsTMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarRegistroToolStripMenuItem});
            this.cmsTMS.Name = "cmsTMS";
            this.cmsTMS.Size = new System.Drawing.Size(153, 26);
            // 
            // borrarRegistroToolStripMenuItem
            // 
            this.borrarRegistroToolStripMenuItem.Name = "borrarRegistroToolStripMenuItem";
            this.borrarRegistroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.borrarRegistroToolStripMenuItem.Text = "Borrar Registro";
            this.borrarRegistroToolStripMenuItem.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tsTMS
            // 
            this.tsTMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargar,
            this.btnGuardar,
            this.btnImprimir,
            this.btnBuscar});
            this.tsTMS.Location = new System.Drawing.Point(0, 0);
            this.tsTMS.Name = "tsTMS";
            this.tsTMS.Size = new System.Drawing.Size(800, 25);
            this.tsTMS.TabIndex = 1;
            this.tsTMS.Text = "toolStrip1";
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
            // gbTMS
            // 
            this.gbTMS.Controls.Add(this.btnAgregar);
            this.gbTMS.Controls.Add(this.tbMes);
            this.gbTMS.Controls.Add(this.tbPrestacionesPorLibro);
            this.gbTMS.Controls.Add(this.tbLibro);
            this.gbTMS.Controls.Add(this.tbID);
            this.gbTMS.Controls.Add(this.label4);
            this.gbTMS.Controls.Add(this.label3);
            this.gbTMS.Controls.Add(this.label2);
            this.gbTMS.Controls.Add(this.label1);
            this.gbTMS.Location = new System.Drawing.Point(12, 47);
            this.gbTMS.Name = "gbTMS";
            this.gbTMS.Size = new System.Drawing.Size(258, 179);
            this.gbTMS.TabIndex = 2;
            this.gbTMS.TabStop = false;
            this.gbTMS.Text = "Datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 133);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbMes
            // 
            this.tbMes.Location = new System.Drawing.Point(125, 107);
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(100, 20);
            this.tbMes.TabIndex = 7;
            // 
            // tbPrestacionesPorLibro
            // 
            this.tbPrestacionesPorLibro.Location = new System.Drawing.Point(125, 81);
            this.tbPrestacionesPorLibro.Name = "tbPrestacionesPorLibro";
            this.tbPrestacionesPorLibro.Size = new System.Drawing.Size(100, 20);
            this.tbPrestacionesPorLibro.TabIndex = 6;
            // 
            // tbLibro
            // 
            this.tbLibro.Location = new System.Drawing.Point(125, 55);
            this.tbLibro.Name = "tbLibro";
            this.tbLibro.Size = new System.Drawing.Size(100, 20);
            this.tbLibro.TabIndex = 5;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(125, 25);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prestaciones Por Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // gbDatosRegistrados
            // 
            this.gbDatosRegistrados.Controls.Add(this.dgvTMS);
            this.gbDatosRegistrados.Location = new System.Drawing.Point(276, 28);
            this.gbDatosRegistrados.Name = "gbDatosRegistrados";
            this.gbDatosRegistrados.Size = new System.Drawing.Size(512, 410);
            this.gbDatosRegistrados.TabIndex = 3;
            this.gbDatosRegistrados.TabStop = false;
            this.gbDatosRegistrados.Text = "Datos Registrados";
            // 
            // dgvTMS
            // 
            this.dgvTMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTMS.Location = new System.Drawing.Point(3, 16);
            this.dgvTMS.Name = "dgvTMS";
            this.dgvTMS.Size = new System.Drawing.Size(506, 391);
            this.dgvTMS.TabIndex = 0;
            this.dgvTMS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTMS_CellClick);
            this.dgvTMS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTMS_CellDoubleClick);
            // 
            // frmRegistroTMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDatosRegistrados);
            this.Controls.Add(this.gbTMS);
            this.Controls.Add(this.tsTMS);
            this.Name = "frmRegistroTMS";
            this.Text = "frmRegistroTMS";
            this.Load += new System.EventHandler(this.frmRegistroTMS_Load);
            this.cmsTMS.ResumeLayout(false);
            this.tsTMS.ResumeLayout(false);
            this.tsTMS.PerformLayout();
            this.gbTMS.ResumeLayout(false);
            this.gbTMS.PerformLayout();
            this.gbDatosRegistrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdTMS;
        private System.Windows.Forms.SaveFileDialog sfdTMS;
        private System.Windows.Forms.ContextMenuStrip cmsTMS;
        private System.Windows.Forms.ToolStrip tsTMS;
        private System.Windows.Forms.ToolTip ttTMS;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.GroupBox gbTMS;
        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.TextBox tbPrestacionesPorLibro;
        private System.Windows.Forms.TextBox tbLibro;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosRegistrados;
        private System.Windows.Forms.ToolStripMenuItem borrarRegistroToolStripMenuItem;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvTMS;
    }
}