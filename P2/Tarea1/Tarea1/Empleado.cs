using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Empleado : MiembroDeLaComunidad
    {
        public int Saldo { get; set; }
        public DateTime Horario { get; set; }

        public void Guardar ()
        {
            Console.WriteLine("Guardando Empleado");
        }

    }
}
