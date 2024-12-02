using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduStats.Estructuras;

namespace EduStats.Servicios
{
    internal class GDLArchivoServicio
    {
        public void GuardarArchivoGDL(List<GDL> gdls, string rutaArchivoGDL)
        {
            using (FileStream archivoGDL = new FileStream(rutaArchivoGDL, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritorGDL = new BinaryWriter(archivoGDL))
                {
                    foreach (GDL c in gdls)
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

        public List<GDL> CagarDatosGDL(string rutaArchivoGDL)
        {
            List<GDL> gdls = new List<GDL>();
            if(!File.Exists(rutaArchivoGDL))
            {
                return gdls;
            }
            using (FileStream archivoGDL = new FileStream(rutaArchivoGDL, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lectorGDL = new BinaryReader(archivoGDL))
                {
                    while(archivoGDL.Position != archivoGDL.Length)
                    {
                        int id = lectorGDL.ReadInt32();
                        int tamano = lectorGDL.ReadInt32();
                        char[] libroArray = lectorGDL.ReadChars(tamano);
                        string libro = new string (libroArray);
                        char[] generoArray = lectorGDL.ReadChars(tamano);
                        string genero = new string (generoArray);
                        int CantidadDePrestaciones = lectorGDL.ReadInt32 ();
                        int PrestacionesPorLibro = lectorGDL.ReadInt32 ();  

                        GDL gdl = new GDL();  
                        gdl.ID = id;    
                        gdl.Libro = libro;
                        gdl.Genero = genero;
                        gdl.CantidadDePrestaciones = CantidadDePrestaciones;
                        gdl.PrestacionesPorLibro = PrestacionesPorLibro;
                        gdls.Add (gdl);

                    }
                }
            }
            return gdls;

        }
    }
}
