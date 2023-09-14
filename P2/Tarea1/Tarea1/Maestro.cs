using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Maestro : Docente
    {
        public int Secciones { get; set; }
        public string Materia { get; set; }

        public void Guardar () 
        {
            Console.WriteLine("Guardando Maestro");
        }
    }
}
