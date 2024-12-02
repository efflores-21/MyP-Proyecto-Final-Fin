using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduStats.Estructuras;

namespace EduStats.Servicios
{
    internal class TMSArchivoServicio
    {
        public void GuardarArchivoTMS(List<TMS> tmss, string rutaArchivoTMS)
        {
            using (FileStream archivoTMS = new FileStream(rutaArchivoTMS, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritorTMS = new BinaryWriter(archivoTMS))
                {
                    foreach (TMS c in tmss)
                    {
                        escritorTMS.Write(c.ID);
                        escritorTMS.Write(c.Libro.Length);
                        escritorTMS.Write(c.Libro.ToCharArray());
                        escritorTMS.Write(c.PrestacionesPorLibro);
                        escritorTMS.Write(c.Mes.Length);
                        escritorTMS.Write(c.Mes.ToCharArray());
                    }
                }
            }
        }

        public List<TMS> CagarDatosTMS(string rutaArchivoTMS)
        {
            List<TMS> tmss = new List<TMS>();
            if (!File.Exists(rutaArchivoTMS))
            {
                return tmss;
            }
            using (FileStream archivoTMS = new FileStream(rutaArchivoTMS, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lectorTMS = new BinaryReader(archivoTMS))
                {
                    while (archivoTMS.Position != archivoTMS.Length)
                    {
                        int id = lectorTMS.ReadInt32();
                        int tamano = lectorTMS.ReadInt32();
                        char[] libroArray = lectorTMS.ReadChars(tamano);
                        string libro = new string(libroArray);
                        int PrestacionesPorLibro = lectorTMS.ReadInt32();
                        char[] MesArray = lectorTMS.ReadChars(tamano);
                        string mes = new string(MesArray);

                        TMS tms = new TMS();
                        tms.ID = id;
                        tms.Libro = libro;
                        tms.PrestacionesPorLibro = PrestacionesPorLibro;
                        tms.Mes = mes;
                        tmss.Add(tms);

                    }
                }
            }
            return tmss;

        }
    }
}

