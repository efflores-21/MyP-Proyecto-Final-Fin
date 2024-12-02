using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduStats.Estructuras;

namespace EduStats.Servicios
{
    internal class CSArchivoServicio
    {
        public void GuardarArchivoCS(List<CS> css, string rutaArchivoCS)
        {
            using (FileStream archivoCS = new FileStream(rutaArchivoCS, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritorCS = new BinaryWriter(archivoCS))
                {
                    foreach (CS c in css)
                    {
                        escritorCS.Write(c.Mes.Length);
                        escritorCS.Write(c.Mes.ToCharArray());
                        escritorCS.Write(c.Carrera.Length);
                        escritorCS.Write(c.Carrera.ToCharArray());
                        escritorCS.Write(c.NumeroDeLibrosSolicitados);
                    }
                }
            }
        }

        public List<CS> CargarDatosCS(string rutaArchivoCS)
        {
            List<CS> css = new List<CS>();
            if (!File.Exists(rutaArchivoCS))
            {
                return css;
            }
            using (FileStream archivoCS = new FileStream(rutaArchivoCS, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lectorCS = new BinaryReader(archivoCS))
                {
                    while (archivoCS.Position != archivoCS.Length)
                    {
                        int tamano = lectorCS.ReadInt32();
                        char[] mesArray = lectorCS.ReadChars(tamano);
                        string mes = new string(mesArray);
                        char[] carreraArray = lectorCS.ReadChars(tamano);
                        string carrera = new string(carreraArray);
                        int numerodelibrossolicitados = lectorCS.ReadInt32();

                        CS cs = new CS();
                        cs.Mes = mes;
                        cs.Carrera = carrera;
                        cs.NumeroDeLibrosSolicitados = numerodelibrossolicitados;
                        css.Add(cs);
                    }
                }
                return css;
            }
        }
    }
}
