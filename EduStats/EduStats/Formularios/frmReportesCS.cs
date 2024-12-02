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
    public partial class frmReportesCS : Form
    {
        public frmReportesCS()
        {
            InitializeComponent();
        }

        private void frmReportesCS_Load(object sender, EventArgs e)
        {

            this.rvCS.RefreshReport();
        }
    }
}
