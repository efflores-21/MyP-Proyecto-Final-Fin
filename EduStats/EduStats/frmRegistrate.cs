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

namespace EduStats
{
    public partial class frmRegistrate : Form
    {
        public frmRegistrate()
        {
            InitializeComponent();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que tbCIF y TbContraseña tengan valores válidos
                if (string.IsNullOrWhiteSpace(tbCIF.Text) || string.IsNullOrWhiteSpace(TbContraseña.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Define la ruta relativa para guardar el archivo
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Usuarios");
                string filePath = Path.Combine(folderPath, tbCIF.Text + ".txt");

                // Asegúrate de que la carpeta exista
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Escribe el archivo
                using (TextWriter RegistrarUsuario = new StreamWriter(filePath, true))
                {
                    RegistrarUsuario.WriteLine(TbContraseña.Text);
                }

                MessageBox.Show("Se registró correctamente.", "EduStats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmInicioDeSesion frmInicioDeSesion = new frmInicioDeSesion();
                frmInicioDeSesion.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
