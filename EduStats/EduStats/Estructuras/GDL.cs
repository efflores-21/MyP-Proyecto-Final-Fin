using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduStats.Estructuras
{
    public struct GDL
    {
        public int ID {  get; set; }    
        public string Libro {  get; set; }  
        public string Genero { get; set; }  
        public int CantidadDePrestaciones { get; set; } 
        public int PrestacionesPorLibro { get; set; }
    }


}
