using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduStats.Estructuras;

namespace EduStats.Dao
{
    internal class CSDao
    {
        private List<CS> css;
        public CSDao()
        {
            css = new List<CS>();
        }
        public void AgregarCS(CS cs)
        {
            css.Add(cs);
            GuardarArchivoCS();
        }
        public void ActualizarCS(CS cs)
        {
            int index = css.FindIndex(item => item.NumeroDeLibrosSolicitados == cs.NumeroDeLibrosSolicitados);
            if (index != -1)
            {
                css[index] = cs;
            }
            GuardarArchivoCS();
        }

        public List<CS> ListarCS(string datoCS)
        {
            css.Clear();
            CargarArchivoCS();
            if (string.IsNullOrEmpty(datoCS))
            {
                return css;
            }
            return css.FindAll(item => item.Carrera.Contains(datoCS));
        }

        public void SetListCS(List<CS> listsCS)
        {
            css = listsCS;
        }

        public CS BuscarCS(int numerodelibrossolicitadosCS)
        {
            return css.Find(item => item.NumeroDeLibrosSolicitados == numerodelibrossolicitadosCS);
        }
        public int BuscarIndexCS(int datosCS)
        {
            return css.FindIndex(item => item.NumeroDeLibrosSolicitados == datosCS);
        }

        public void EliminarCS(CS cs)
        {
            css.Remove(cs);
            GuardarArchivoCS();
        }
        public void OrdenarCS()
        {
            css.Sort((x, y) => x.Carrera.CompareTo(y.Carrera));
        }

        private void GuardarArchivoCS()
        {
            string rutaArchivoCS = "css.dat";
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

        private void CargarArchivoCS()
        {
            string rutaArchivoCS = "css.dat";
            if (!File.Exists(rutaArchivoCS))
            {
                return;
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
            }
        }
    }
}
