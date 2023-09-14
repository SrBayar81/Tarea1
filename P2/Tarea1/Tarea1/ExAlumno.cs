using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class ExAlumno : MiembroDeLaComunidad
    {
           public string Carrera { get; set; }

        public void Guardar ()
        {
            Console.WriteLine("Guardando ExAlumno");
        }
    }
}
