namespace EduStats.Formularios
{
    partial class frmReportesGDL
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
            this.rvGDL = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvGDL
            // 
            this.rvGDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvGDL.Location = new System.Drawing.Point(0, 0);
            this.rvGDL.Name = "rvGDL";
            this.rvGDL.ServerReport.BearerToken = null;
            this.rvGDL.Size = new System.Drawing.Size(800, 450);
            this.rvGDL.TabIndex = 0;
            // 
            // frmReportesGDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvGDL);
            this.Name = "frmReportesGDL";
            this.Text = "frmReportesGDL";
            this.Load += new System.EventHandler(this.frmReportesGDL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rvGDL;
    }
}