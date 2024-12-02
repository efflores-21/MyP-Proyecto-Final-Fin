using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduStats.Dao;
using EduStats.Estructuras;
using EduStats.Servicios;
using Microsoft.Reporting.WinForms;

namespace EduStats.Formularios
{
    public partial class frmRegistroGDL : Form
    {
        private GDLDao gdls;
        private GDL gdlsel = new GDL(); 
        public frmRegistroGDL()
        {
            InitializeComponent();
            gdls = new GDLDao();    
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GDL gdl = new GDL();
            try
            {
                gdl.ID = int.Parse(tbID.Text);
                gdl.Libro = tbLibro.Text;
                gdl.Genero = tbGenero.Text;
                gdl.CantidadDePrestaciones = int.Parse(tbCantidadDePrestaciones.Text);
                gdl.PrestacionesPorLibro = int.Parse(tbPrestacionesPorLibro.Text);
            }
            catch 
            {
                MessageBox.Show("Error al Ingresar los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int index = gdls.BuscarIndexGDL(gdl.ID);
            if (index != -1)
            {
                gdls.ActualizarGDL(gdl);
            }
            else
            {
                gdls.AgregarGDL(gdl);
            }
            MostrarDatosGDL();
            
        }
        private void MostrarDatosGDL()
        {
            gdls.OrdernarGDL();
            dgvGDL.DataSource = null;
            dgvGDL.DataSource = gdls.ListarGDL("");
        }

        private void dgvGDL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRowGDL = dgvGDL.CurrentRow;
            if (currentRowGDL != null)
            {
                gdlsel.ID = int.Parse(currentRowGDL.Cells[0].Value.ToString());
                gdlsel.Libro = currentRowGDL.Cells[1].Value.ToString();
                gdlsel.Genero = currentRowGDL.Cells[2].Value.ToString();
                gdlsel.CantidadDePrestaciones = int.Parse(currentRowGDL.Cells[3].Value.ToString());
                gdlsel.PrestacionesPorLibro = int.Parse(currentRowGDL.Cells[4].Value.ToString());

                tbID.Text = gdlsel.ID.ToString();
                tbLibro.Text = gdlsel.Libro;
                tbGenero.Text = gdlsel.Genero; 
                tbCantidadDePrestaciones.Text = gdlsel.CantidadDePrestaciones.ToString();
                tbPrestacionesPorLibro.Text = gdlsel.PrestacionesPorLibro.ToString();    
            }
        }
        private void ImprimirReporteGDL()
        {
            ReportDataSource dataSource = new ReportDataSource("DsGDL", gdls.ListarGDL(tbLibro.Text));

            frmReportesGDL frm = new frmReportesGDL();
            frm.rvGDL.LocalReport.DataSources.Clear();
            frm.rvGDL.LocalReport.DataSources.Add(dataSource);
            frm.rvGDL.LocalReport.ReportEmbeddedResource = "Registros.Reportes.rptGeneroDeLibroMasPrestados.rdlc";
            frm.rvGDL.RefreshReport();
            frm.ShowDialog();
        }
        private void QuitarRegistroGDL()
        {
            try
            {
                var opcionGDl = MessageBox.Show($"Desea eliminar el Registro: {gdlsel}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                gdls.EliminarGDL(gdlsel);
                MessageBox.Show("Libro Eliminado", "Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
        private void GuardarDatosGDL()
        {
            try
            {
                sfdGDL.Filter = "ArchivosDAT (*.dat)|*.dat";
                sfdGDL.Title = "Guardar archivo";

                if (sfdGDL.ShowDialog() == DialogResult.OK)
                {
                    GDLArchivoServicio archivoGDL = new GDLArchivoServicio();
                    archivoGDL.GuardarArchivoGDL(gdls.ListarGDL(""), sfdGDL.FileName);
                    MessageBox.Show("Se ha Guardado el Archivo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarDatosGDL()
        {
            ofdGDL.InitialDirectory = "C:\\";
            ofdGDL.Filter = "Archivos DAT (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
            ofdGDL.RestoreDirectory = true;
            if (ofdGDL.ShowDialog() == DialogResult.OK)
            {
                string rutaGDL = ofdGDL.FileName;
                GDLArchivoServicio archivoGDL = new GDLArchivoServicio();
                gdls.SetListsGDL(archivoGDL.CagarDatosGDL(rutaGDL));
                MostrarDatosGDL();
            }
            else
            {
                MessageBox.Show("No se Selecciono Ningun Archivo");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            QuitarRegistroGDL();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatosGDL();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatosGDL();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirReporteGDL();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvGDL.DataSource = null;
            dgvGDL.DataSource = gdls.ListarGDL(tbLibro.Text);
        }

        private void frmRegistroGDL_Load(object sender, EventArgs e)
        {
            MostrarDatosGDL();
        }

        private void dgvGDL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index != -1)
            {
                gdlsel.ID = int.Parse(dgvGDL.Rows[index].Cells[0].Value.ToString());
                gdlsel.Libro = dgvGDL.Rows[index].Cells[1].Value.ToString();
                gdlsel.Genero = dgvGDL.Rows[index].Cells[2].Value.ToString();
                gdlsel.CantidadDePrestaciones = int.Parse(dgvGDL.Rows[index].Cells[3].ToString());
                gdlsel.PrestacionesPorLibro = int.Parse(dgvGDL.Rows[index].Cells[4].ToString());
            }
        }
    }
}
