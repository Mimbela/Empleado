using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce nombre empleado o intro para empleado genérico:");
            string nombre = Console.ReadLine();
            if (nombre.Length==0)
            {
                Empleado empleadoGenerico = new Empleado();
                empleadoGenerico.Imprimir();
            }
            else
            {
                Console.WriteLine("Sueldo");
                int sueldo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Cargo");
                string cargo = Console.ReadLine();

                Empleado empleado = new Empleado(nombre, sueldo, cargo);

                empleado.Imprimir();
            }
        }
    }
}
