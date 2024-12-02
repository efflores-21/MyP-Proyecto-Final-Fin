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
    public partial class frmReportesTMS : Form
    {
        public frmReportesTMS()
        {
            InitializeComponent();
        }

        private void frmReportesTMS_Load(object sender, EventArgs e)
        {

            this.rvTMS.RefreshReport();
        }
    }
}
