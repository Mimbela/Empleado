using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class Empleado
    {
        const int sueldo = 1000;
        const string nombre = "Nuevo Empleado";
        const string cargo = "Empleado Base";

        public string Nombre { get; set; }
        public int  Sueldo { get; set; }
        public string Cargo { get; set; }

        public Empleado()
        {
            Nombre = nombre;
            Sueldo = sueldo;
            Cargo = cargo;
        }

        public Empleado (string nom, int suel , string car)
        {
            Nombre = nom;
            Sueldo = suel;
            Cargo = car;
        }

        public void  Imprimir()
        {
            Console.WriteLine(" El sueldo de {0} con cargo {1} es {2}", Nombre, Cargo, Sueldo);
            Console.ReadKey();
        }

    }
}
