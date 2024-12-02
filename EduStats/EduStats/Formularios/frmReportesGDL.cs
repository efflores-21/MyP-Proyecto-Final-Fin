using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduStats.Formularios
{
    public partial class frmReportesGDL : Form
    {
        public frmReportesGDL()
        {
            InitializeComponent();
        }

        private void frmReportesGDL_Load(object sender, EventArgs e)
        {

            this.rvGDL.RefreshReport();
        }
    }
}
