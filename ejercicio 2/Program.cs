using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar;

            do {
                string sexo;
                string nombre;
                string edad;

                Console.WriteLine("seleccione su sexo");
                sexo = Console.ReadLine();
                Console.WriteLine("ingrese nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese la edad");
                edad = Console.ReadLine();


                if (sexo == "m") {
                    Console.WriteLine("El Sra " + nombre + " a sido registrada con exito");
                }
                else if (sexo == "h") {
                    Console.WriteLine("La Sr " + nombre + " a sido registrada con exito");
                }
                Console.WriteLine("Desea continuar S/N");
                continuar = Console.ReadLine();
            } while (continuar == "N");

            Console.ReadKey();
        }

    }
}
