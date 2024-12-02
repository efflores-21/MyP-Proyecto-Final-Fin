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
    public partial class frmRegistroCS : Form
    {
        private CSDao css;
        private CS csssel = new CS();

        public frmRegistroCS()
        {
            InitializeComponent();
            css = new CSDao();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CS cs = new CS();
            try
            {
                cs.Mes = tbMes.Text;
                cs.Carrera = tbCarrera.Text;
                cs.NumeroDeLibrosSolicitados = int.Parse(tbNumeroDeLibrosSolicitados.Text);
            }
            catch
            {
                MessageBox.Show("Error al Ingresar los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int index = css.BuscarIndexCS(cs.NumeroDeLibrosSolicitados);
            if (index != -1)
            {
                css.ActualizarCS(cs);
            }
            else
            {
                css.AgregarCS(cs);
            }
            MostrarDatosCS();
        }
        private void MostrarDatosCS()
        {
            css.OrdenarCS();
            dgvCS.DataSource = null;
            dgvCS.DataSource = css.ListarCS("");
        }

        private void dgvCS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRowCS = dgvCS.CurrentRow;
            if (currentRowCS != null)
            {
                csssel.Mes = currentRowCS.Cells[0].Value.ToString();
                csssel.Carrera = currentRowCS.Cells[1].Value.ToString();
                csssel.NumeroDeLibrosSolicitados = int.Parse(currentRowCS.Cells[2].Value.ToString());

                tbMes.Text = csssel.Mes;
                tbCarrera.Text = csssel.Carrera;
                tbNumeroDeLibrosSolicitados.Text = csssel.NumeroDeLibrosSolicitados.ToString();
            }
        }
        private void ImprimirReporteCS()
        {
            ReportDataSource dataSourceCS = new ReportDataSource("DsCS", css.ListarCS(tbCarrera.Text));

            frmReportesCS frmReportesCS = new frmReportesCS();
            frmReportesCS.rvCS.LocalReport.DataSources.Clear();
            frmReportesCS.rvCS.LocalReport.DataSources.Add(dataSourceCS);
            frmReportesCS.rvCS.LocalReport.ReportEmbeddedResource = "Registro.Reportes.rptCarreraSolicita.rdlc";
            frmReportesCS.rvCS.RefreshReport();
            frmReportesCS.ShowDialog();
        }
        private void QuitarRegistrosCS()
        {
            try
            {
                var opcionCS = MessageBox.Show($"Desea Eliminar el Registro: {csssel.Carrera}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                css.EliminarCS(csssel);
                MessageBox.Show("Registro Eliminado", "EduStats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GuardarDatosCS()
        {
            try
            {
                sfdCS.Filter = "Archivos DAT (*.dat)|*.dat";
                sfdCS.Title = "Guardar Archivo";
                if (sfdCS.ShowDialog() == DialogResult.OK)
                {
                    CSArchivoServicio archivoCS = new CSArchivoServicio();
                    archivoCS.GuardarArchivoCS(css.ListarCS(""), sfdCS.FileName);
                    MessageBox.Show("Se ha Guardado el Archivo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosCS()
        {
            sfdCS.InitialDirectory = "C:\\";
            sfdCS.Filter = "Archivos DAT (*.dat)|*.dat|Todos Los Archivos (*.*)|*.*";
            sfdCS.RestoreDirectory = true;

            if (ofdCS.ShowDialog() == DialogResult.OK)
            {
                string rutaCS = ofdCS.FileName;
                CSArchivoServicio archivoCS = new CSArchivoServicio();
                css.SetListCS(archivoCS.CargarDatosCS(rutaCS));
                MostrarDatosCS();
            }
            else
            {
                MessageBox.Show("No se Selecciono Ningun Arhivo.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            QuitarRegistrosCS();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatosCS();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatosCS();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirReporteCS();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCS.DataSource = null;
            dgvCS.DataSource = css.ListarCS(tbCarrera.Text);
        }

        private void frmRegsitroCS_Load(object sender, EventArgs e)
        {
            MostrarDatosCS();
        }

        private void dgvCS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                csssel.Mes = dgvCS.Rows[index].Cells[0].Value.ToString();
                csssel.Carrera = dgvCS.Rows[index].Cells[1].Value.ToString();
                csssel.NumeroDeLibrosSolicitados = int.Parse(dgvCS.Rows[index].Cells[2].Value.ToString());
            }
        }
    }
}

