using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            int numero2 = 10;
            int numero3 = 7;

            int suma = numero1 + numero2 + numero3;
            Console.WriteLine("El perímetro del triangulo es:" + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
