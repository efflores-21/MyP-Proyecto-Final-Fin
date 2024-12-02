using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduStats.Estructuras
{
    public struct TMS
    {
        public int ID { get; set; }
        public string Libro { get; set; }
        public int PrestacionesPorLibro { get; set; }
        public string Mes { get; set; }
    }
}
