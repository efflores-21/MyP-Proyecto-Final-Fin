using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduStats.Estructuras;

namespace EduStats.Dao
{
    internal class GDLDao
    {
        private List<GDL> gdls;
        public GDLDao()
        {
            gdls = new List<GDL>();
        }
        public void AgregarGDL(GDL gdl)
        {
            gdls.Add(gdl);
            GuardarArchivoGDL();
        }
        public void  ActualizarGDL(GDL gdl)
        {
            int index = gdls.FindIndex(item => item.ID == gdl.ID);
            if (index != -1)
            {
                gdls[index] = gdl;
            }
            GuardarArchivoGDL();
        }
        public List<GDL> ListarGDL(string dato)
        {
            gdls.Clear();
            CargarArchivoGDL();
            if (string.IsNullOrEmpty(dato))
            {
                return gdls;
            }
            return gdls.FindAll(item => item.Libro.Contains(dato));
        }

        public void SetListsGDL(List<GDL> list)
        {
            gdls = list;
        }
        public GDL BuscarGDL(int id)
        {
            return gdls.Find(item => item.ID == id);
        }
        public int BuscarIndexGDL(int id)
        {
            return gdls.FindIndex(item => item.ID == id);
        }
        public void EliminarGDL (GDL gdl)
        {
            gdls.Remove(gdl);
            GuardarArchivoGDL();
        }
        public void OrdernarGDL()
        {
            gdls.Sort((x, y) => x.Libro.CompareTo(y.Libro));
        }
        private void GuardarArchivoGDL()
        {
            string rutaArchivoGDL = "gdls.dat";
            using (FileStream archivoGDL = new FileStream (rutaArchivoGDL, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritorGDL = new BinaryWriter(archivoGDL))
                {
                    foreach(GDL c in gdls)
                    {
                        escritorGDL.Write(c.ID);
                        escritorGDL.Write(c.Libro.Length);
                        escritorGDL.Write(c.Libro.ToCharArray());
                        escritorGDL.Write(c.Genero.Length);
                        escritorGDL.Write(c.Genero.ToCharArray());
                        escritorGDL.Write(c.CantidadDePrestaciones);
                        escritorGDL.Write(c.PrestacionesPorLibro);
                    }
                }
            }
        }

        private void CargarArchivoGDL()
        {
            string rutaArchivoGDL = "gdls.dat";
            if(!File.Exists(rutaArchivoGDL))
            {
                return;
            }
            using (FileStream archivoGDL = new FileStream (rutaArchivoGDL, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lectorGDL = new BinaryReader(archivoGDL))
                {
                    while (archivoGDL.Position != archivoGDL.Length)
                    {
                        int id = lectorGDL.ReadInt32();
                        int tamano = lectorGDL.ReadInt32();
                        char[] libroArray = lectorGDL.ReadChars(tamano);
                        string libro = new string(libroArray);
                        char[] generoArray = lectorGDL.ReadChars(tamano);
                        string genero = new string(generoArray);
                        int CantidadDePrestaciones = lectorGDL.ReadInt32();
                        int PrestacionesPorLibro = lectorGDL.ReadInt32();

                        GDL gdl = new GDL
                        {
                            ID = id,
                            Libro = libro,
                            Genero = genero,
                            CantidadDePrestaciones = CantidadDePrestaciones,
                            PrestacionesPorLibro = PrestacionesPorLibro
                        };
                        gdls.Add(gdl);
                    }
                }

            }
        }
    }
}
