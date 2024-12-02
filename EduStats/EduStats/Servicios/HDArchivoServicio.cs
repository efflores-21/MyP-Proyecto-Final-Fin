using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduStats.Estructuras;

namespace EduStats.Servicios
{
    internal class HDArchivoServicio
    {
        public void GuardarArchivoHD(List<HD> hds, string rutaArchivoHD)
        {
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

        public List<HD> CargarHorasDiarias(string rutaArchivoHD)
        {
            List<HD> hds = new List<HD>();
            if (!File.Exists(rutaArchivoHD))
            {
                return hds;
            }
            using (FileStream archivoHD = new FileStream(rutaArchivoHD, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lectorHD = new BinaryReader(archivoHD))
                {
                    while (archivoHD.Position != archivoHD.Length)
                    {
                        int horas = lectorHD .ReadInt32();
                        int tamano = lectorHD .ReadInt32();
                        char[] influenciaArray = lectorHD.ReadChars(tamano);
                        string influencia = new string (influenciaArray);
                        char[] motivosArray = lectorHD.ReadChars(tamano);
                        string motivos = new string (motivosArray);

                        HD hd = new HD();
                        hd.HoraHD = horas;
                        hd.InfluenciaHD = influencia;
                        hd.MotivosHD = motivos;
                        hds.Add(hd);    
                    }
                }
                return hds;
            }
        }
    }
}
