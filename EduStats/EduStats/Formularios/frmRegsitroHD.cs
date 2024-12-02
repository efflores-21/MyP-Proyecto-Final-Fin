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
using EduStats.Estructuras;
using EduStats.Servicios;
using Microsoft.Reporting.WinForms;

namespace EduStats.Formularios
{
    public partial class frmRegsitroHD : Form
    {
        private HDDao hds;
        private HD hdsel = new HD();

        public frmRegsitroHD()
        {
            InitializeComponent();
            hds = new HDDao();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HD hd = new HD();
            try
            {
                hd.HoraHD = int.Parse(tbHoras.Text);
                hd.InfluenciaHD = tbInfluencia.Text;
                hd.MotivosHD = tbMotivo.Text;
            }
            catch
            {
                MessageBox.Show("Error al Ingresar los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int index = hds.BuscarHoras(hd.HoraHD);
            if (index != -1)
            {
                hds.ActualizarHD(hd);
            }
            else
            {
                hds.AgregarHD(hd);
            }
            MostrarDatosHD();
        }
        private void MostrarDatosHD()
        {
            hds.OrdenarHD();
            dgvHD.DataSource = null;
            dgvHD.DataSource = hds.ListarHD("");
        }

        private void dgvHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRowHD = dgvHD.CurrentRow;
            if (currentRowHD != null)
            {
                hdsel.HoraHD = int.Parse(currentRowHD.Cells[0].Value.ToString());
                hdsel.InfluenciaHD = currentRowHD.Cells[1].Value.ToString();
                hdsel.MotivosHD = currentRowHD.Cells[2].Value.ToString();

                tbHoras.Text = hdsel.HoraHD.ToString();
                tbInfluencia.Text = hdsel.InfluenciaHD;
                tbMotivo.Text = hdsel.MotivosHD;
            }
        }
        private void ImprimirReporteHD()
        {
            ReportDataSource dataSourceHD = new ReportDataSource("DsHD", hds.ListarHD(tbInfluencia.Text));

            frmReportesHD frmReportesHD = new frmReportesHD();
            frmReportesHD.rvHD.LocalReport.DataSources.Clear();
            frmReportesHD.rvHD.LocalReport.DataSources.Add(dataSourceHD);
            frmReportesHD.rvHD.LocalReport.ReportEmbeddedResource = "Registro.Reportes.rptHorasDiarias.rdlc";
            frmReportesHD.rvHD.RefreshReport();
            frmReportesHD.ShowDialog();
        }
        private void QuitarRegistrosHD()
        {
            try
            {
                var opcionHD = MessageBox.Show($"Desea Eliminar el Registro: {hdsel.InfluenciaHD}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                hds.EliminarHD(hdsel);
                MessageBox.Show("Registro Eliminado", "EduStats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GuardarDatosHD()
        {
            try
            {
                sfdHD.Filter = "Archivos DAT (*.dat)|*.dat";
                sfdHD.Title = "Guardar Archivo";
                if (sfdHD.ShowDialog() == DialogResult.OK)
                {
                    HDArchivoServicio archivoHD = new HDArchivoServicio();
                    archivoHD.GuardarArchivoHD(hds.ListarHD(""), sfdHD.FileName);
                    MessageBox.Show("Se ha Guardado el Archivo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosHD()
        {
            sfdHD.InitialDirectory = "C:\\";
            sfdHD.Filter = "Archivos DAT (*.dat)|*.dat|Todos Los Archivos (*.*)|*.*";
            sfdHD.RestoreDirectory = true;

            if (ofdHD.ShowDialog() == DialogResult.OK)
            {
                string rutaHD = ofdHD.FileName;
                HDArchivoServicio archivoHD = new HDArchivoServicio();
                hds.SetList(archivoHD.CargarHorasDiarias(rutaHD));
                MostrarDatosHD();
            }
            else
            {
                MessageBox.Show("No se Selecciono Ningun Arhivo.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            QuitarRegistrosHD();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatosHD();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatosHD();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirReporteHD();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvHD.DataSource = null;
            dgvHD.DataSource = hds.ListarHD(tbInfluencia.Text);
        }

        private void frmRegsitroHD_Load(object sender, EventArgs e)
        {
            MostrarDatosHD();
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                hdsel.HoraHD = int.Parse(dgvHD.Rows[index].Cells[0].Value.ToString());
                hdsel.InfluenciaHD = dgvHD.Rows[index].Cells[1].Value.ToString();
                hdsel.MotivosHD = dgvHD.Rows[index].Cells[2].Value.ToString();  
            }
        }
    }
}
