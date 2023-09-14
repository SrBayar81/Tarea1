using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Administrativo : Empleado
    {
        public int NumEdificio { get; set; }

        public void Guardar () 
        {
            Console.WriteLine("Guardando Administrativo");
        }
    }
}
