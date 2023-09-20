using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Area
    {
        public int IdArea { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<object>  Areas{ get; set;}

        public Area(int idArea, string nombre, string descripcion)
        {
            IdArea = idArea;
            Nombre = nombre;
            Descripcion = descripcion;

        }
        public Area() { 
        
        }
    }
}
