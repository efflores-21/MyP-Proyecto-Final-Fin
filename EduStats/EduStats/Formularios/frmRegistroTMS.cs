using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduStats.Dao;
using EduStats.DataSet;
using EduStats.Estructuras;
using EduStats.Servicios;
using Microsoft.Reporting.WinForms;

namespace EduStats.Formularios
{
    public partial class frmRegistroTMS : Form
    {
        private TMSDao tmss;
        private TMS tmssel = new TMS();
        public frmRegistroTMS()

        {
            InitializeComponent();
            tmss = new TMSDao();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TMS tms = new TMS();
            try
            {
                tms.ID = int.Parse(tbID.Text);
                tms.Libro = tbLibro.Text;
                tms.Mes = tbMes.Text;
                tms.PrestacionesPorLibro = int.Parse(tbPrestacionesPorLibro.Text);
            }
            catch
            {
                MessageBox.Show("Error al Ingresar los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int index = tmss.BuscarIndexTMS(tms.ID);
            if (index != -1)
            {
                tmss.ActualizarTMS(tms);
            }
            else
            {
                tmss.AgregarTMS(tms);
            }
            MostrarDatosTMS();

        }
        private void MostrarDatosTMS()
        {
            tmss.OrdernarTMS();
            dgvTMS.DataSource = null;
            dgvTMS.DataSource = tmss.ListarTMS("");
        }

        private void dgvTMS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRowTMS = dgvTMS.CurrentRow;
            if (currentRowTMS != null)
            {
                tmssel.ID = int.Parse(currentRowTMS.Cells[0].Value.ToString());
                tmssel.Libro = currentRowTMS.Cells[1].Value.ToString();
                tmssel.PrestacionesPorLibro = int.Parse(currentRowTMS.Cells[3].Value.ToString());
                tmssel.Mes = currentRowTMS.Cells[4].Value.ToString();

                tbID.Text = tmssel.ID.ToString();
                tbLibro.Text = tmssel.Libro;
                tbPrestacionesPorLibro.Text = tmssel.PrestacionesPorLibro.ToString();
                tbMes.Text = tmssel.Mes;
            }
        }
        private void ImprimirReporteTMS()
        {
            ReportDataSource dataSource = new ReportDataSource("DsTMS", tmss.ListarTMS(tbLibro.Text));

            frmReportesTMS frm = new frmReportesTMS();
            frm.rvTMS.LocalReport.DataSources.Clear();
            frm.rvTMS.LocalReport.DataSources.Add(dataSource);
            frm.rvTMS.LocalReport.ReportEmbeddedResource = "Registros.Reportes.rptTemporadaMayorSolicitud.rdlc";
            frm.rvTMS.RefreshReport();
            frm.ShowDialog();
        }
        private void QuitarRegistroTMS()
        {
            try
            {
                var opcionTMS = MessageBox.Show($"Desea eliminar el Registro: {tmssel}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                tmss.EliminarTMS(tmssel);
                MessageBox.Show("Libro Eliminado", "Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GuardarDatosTMS()
        {
            try
            {
                sfdTMS.Filter = "ArchivosDAT (*.dat)|*.dat";
                sfdTMS.Title = "Guardar archivo";

                if (sfdTMS.ShowDialog() == DialogResult.OK)
                {
                    TMSArchivoServicio archivoTMS = new TMSArchivoServicio();
                    archivoTMS.GuardarArchivoTMS(tmss.ListarTMS(""), sfdTMS.FileName);
                    MessageBox.Show("Se ha Guardado el Archivo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarDatosTMS()
        {
            ofdTMS.InitialDirectory = "C:\\";
            ofdTMS.Filter = "Archivos DAT (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
            ofdTMS.RestoreDirectory = true;
            if (ofdTMS.ShowDialog() == DialogResult.OK)
            {
                string rutaTMS = ofdTMS.FileName;
                TMSArchivoServicio archivoTMS = new TMSArchivoServicio();
                tmss.SetListsTMS(archivoTMS.CagarDatosTMS(rutaTMS));
                MostrarDatosTMS();
            }
            else
            {
                MessageBox.Show("No se Selecciono Ningun Archivo");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            QuitarRegistroTMS();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatosTMS();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatosTMS();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirReporteTMS();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvTMS.DataSource = null;
            dgvTMS.DataSource = tmss.ListarTMS(tbLibro.Text);
        }

        private void frmRegistroTMS_Load(object sender, EventArgs e)
        {
            MostrarDatosTMS();
        }

        private void dgvTMS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                tmssel.ID = int.Parse(dgvTMS.Rows[index].Cells[0].Value.ToString());
                tmssel.Libro = dgvTMS.Rows[index].Cells[1].Value.ToString();
                tmssel.PrestacionesPorLibro = int.Parse(dgvTMS.Rows[index].Cells[2].ToString());
                tmssel.Mes = dgvTMS.Rows[index].Cells[3].Value.ToString();
            }
        }
    }
}
