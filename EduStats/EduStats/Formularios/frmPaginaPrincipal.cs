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
    public partial class frmPaginaPrincipal : Form
    {
        public frmPaginaPrincipal()
        {
            InitializeComponent();
        }

        private void generoDeLibroMasPrestadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroGDL frmRegistroGDL = new frmRegistroGDL();
            frmRegistroGDL.Show();
        }

        private void horasDiariasConMayorAfluenciaDePersonasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegsitroHD frmRegsitroHD = new frmRegsitroHD();
            frmRegsitroHD.Show();
        }

        private void temporadaConMayorSolicitudDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroTMS frmRegistroTMS = new frmRegistroTMS();
            frmRegistroTMS.Show();
        }

        private void carrerasQueSolicitanMasLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroCS frmRegistroCS = new frmRegistroCS();  
            frmRegistroCS.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var opcion = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicioDeSesion frmInicioDeSesion = new frmInicioDeSesion();
            frmInicioDeSesion.Show();
            this.Close();
        }
    }
}
