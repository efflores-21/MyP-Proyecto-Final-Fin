using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduStats.Estructuras;

namespace EduStats.Dao
{
    internal class HDDao
    {
        private List<HD> hds;
        public HDDao()
        {
            hds = new List<HD>();
        }
        public void AgregarHD(HD hd)
        {
            hds.Add(hd);
            GuardarArchivoHD();
        }
        public void ActualizarHD(HD hd)
        {
            int index = hds.FindIndex(item => item.HoraHD == hd.HoraHD);
            if (index != -1)
            {
                hds[index] = hd;
            }
            GuardarArchivoHD();
        }

        public List<HD> ListarHD(string datoHD)
        {
            hds.Clear();
            CargarArchivoHD();
            if (string.IsNullOrEmpty(datoHD))
            {
                return hds;
            }
            return hds.FindAll(item => item.InfluenciaHD.Contains(datoHD));
        }

        public void SetList(List<HD> listsHD)
        {
            hds = listsHD;
        }

        public HD BuscarHD(int horaHD)
        {
            return hds.Find(item => item.HoraHD == horaHD);
        }
        public int BuscarHoras(int horaHD)
        {
            return hds.FindIndex(item => item.HoraHD == horaHD);
        }

        public void EliminarHD(HD hd)
        {
            hds.Remove(hd);
            GuardarArchivoHD();
        }
        public void OrdenarHD()
        {
            hds.Sort((x, y) => x.InfluenciaHD.CompareTo(y.InfluenciaHD));
        }

        private void GuardarArchivoHD()
        {
            string rutaArchivoHD = "hds.dat";
            using (FileStream archivoHD = new FileStream(rutaArchivoHD, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritorHD = new BinaryWriter(archivoHD))
                {
                    foreach (HD c in hds)
                    {
                        escritorHD.Write(c.HoraHD);
                        escritorHD.Write(c.InfluenciaHD.Length);
                        escritorHD.Write(c.InfluenciaHD.ToCharArray());
                        escritorHD.Write(c.MotivosHD.Length);
                        escritorHD.Write(c.MotivosHD.ToCharArray());
                    }
                }

            }
        }

        private void CargarArchivoHD()
        {
            string rutaArchivoHD = "hds.dat";
            if (!File.Exists(rutaArchivoHD))
            {
                return;
            }

            using (FileStream archivoHD = new FileStream(rutaArchivoHD, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lectorHD = new BinaryReader(archivoHD))
                {
                    while (archivoHD.Position != archivoHD.Length)
                    {
                        int horas = lectorHD.ReadInt32();
                        int tamano = lectorHD.ReadInt32();
                        char[] influenciaArray = lectorHD.ReadChars(tamano);
                        string influencia = new string(influenciaArray);
                        char[] motivosArray = lectorHD.ReadChars(tamano);
                        string motivos = new string(motivosArray);

                        HD hd = new HD();
                        hd.HoraHD = horas;
                        hd.InfluenciaHD = influencia;
                        hd.MotivosHD = motivos;
                        hds.Add(hd);
                    }
                }
            }
        }
    }
}
