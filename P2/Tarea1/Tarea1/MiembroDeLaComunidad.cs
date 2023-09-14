using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class MiembroDeLaComunidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set;}

        public void Guardar ()
        {
            Console.WriteLine("Se esta guardando...");
        }
    }
}
