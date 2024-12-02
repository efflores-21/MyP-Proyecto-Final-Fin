namespace EduStats.Formularios
{
    partial class frmReportesCS
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
            this.rvCS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvCS
            // 
            this.rvCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvCS.Location = new System.Drawing.Point(0, 0);
            this.rvCS.Name = "rvCS";
            this.rvCS.ServerReport.BearerToken = null;
            this.rvCS.Size = new System.Drawing.Size(800, 450);
            this.rvCS.TabIndex = 0;
            // 
            // frmReportesCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvCS);
            this.Name = "frmReportesCS";
            this.Text = "frmReportesCS";
            this.Load += new System.EventHandler(this.frmReportesCS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rvCS;
    }
}