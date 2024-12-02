using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduStats.Estructuras;

namespace EduStats.Dao
{
    internal class TMSDao
    {
        private List<TMS> tmss;
        public TMSDao()
        {
            tmss = new List<TMS>();
        }
        public void AgregarTMS(TMS tms)
        {
            tmss.Add(tms);
            GuardarArchivoTMS();
        }
        public void ActualizarTMS(TMS tms)
        {
            int index = tmss.FindIndex(item => item.ID == tms.ID);
            if (index != -1)
            {
                tmss[index] = tms;
            }
            GuardarArchivoTMS();
        }
        public List<TMS> ListarTMS(string dato)
        {
            tmss.Clear();
            CargarArchivoTMS();
            if (string.IsNullOrEmpty(dato))
            {
                return tmss;
            }
            return tmss.FindAll(item => item.Libro.Contains(dato));
        }

        public void SetListsTMS(List<TMS> list)
        {
            tmss = list;
        }
        public TMS BuscarTMS(int id)
        {
            return tmss.Find(item => item.ID == id);
        }
        public int BuscarIndexTMS(int id)
        {
            return tmss.FindIndex(item => item.ID == id);
        }
        public void EliminarTMS(TMS tms)
        {
            tmss.Remove(tms);
            GuardarArchivoTMS();
        }
        public void OrdernarTMS()
        {
            tmss.Sort((x, y) => x.Libro.CompareTo(y.Libro));
        }
        private void GuardarArchivoTMS()
        {
            string rutaArchivoTMS = "tmss.dat";
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

        private void CargarArchivoTMS()
        {
            string rutaArchivoTMS = "tmss.dat";
            if (!File.Exists(rutaArchivoTMS))
            {
                return;
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
        }
    }
}
