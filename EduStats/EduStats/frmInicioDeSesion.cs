using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduStats.Formularios;

namespace EduStats
{
    public partial class frmInicioDeSesion : Form
    {
        public frmInicioDeSesion()
        {
            InitializeComponent();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(tbCIF.Text) || string.IsNullOrWhiteSpace(TbContraseña.Text))
                {
                    MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Define la ruta relativa al archivo del usuario
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Usuarios");
                string filePath = Path.Combine(folderPath, tbCIF.Text + ".txt");

                // Verifica que el archivo exista
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Usuario no encontrado. Por favor, registrese primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lee la contraseña almacenada y compara
                using (TextReader Inicio = new StreamReader(filePath))
                {
                    string storedPassword = Inicio.ReadLine();
                    if (storedPassword == TbContraseña.Text)
                    {
                        MessageBox.Show("Sesión iniciada correctamente.", "EduStats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abre la página principal y cierra la ventana actual
                        frmPaginaPrincipal frmPaginaPrincipal = new frmPaginaPrincipal();
                        frmPaginaPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta. Por favor, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var opcion = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            frmRegistrate frm = new frmRegistrate();
            frm.Show();
        }
    }
}
