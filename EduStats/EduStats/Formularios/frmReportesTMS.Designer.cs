namespace EduStats.Formularios
{
    partial class frmReportesTMS
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
            this.rvTMS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvTMS
            // 
            this.rvTMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvTMS.Location = new System.Drawing.Point(0, 0);
            this.rvTMS.Name = "rvTMS";
            this.rvTMS.ServerReport.BearerToken = null;
            this.rvTMS.Size = new System.Drawing.Size(800, 450);
            this.rvTMS.TabIndex = 0;
            // 
            // frmReportesTMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvTMS);
            this.Name = "frmReportesTMS";
            this.Text = "frmReportesTMS";
            this.Load += new System.EventHandler(this.frmReportesTMS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rvTMS;
    }
}