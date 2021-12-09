using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crear tres variables de tipo INT asignarles valores estaticos .
//CTRL + K + U
//Crear tres variables de tipo INT y asignarles valores estaticos
//Crear una variable de tipo INT la cual guardarala suma de las tres variables anteriores
//mostrar en pantalla el valos de suma, con el siguiente mensjae "el valor de la suma es;" <suma>

namespace Ejercicio_int
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 5;
            int numero2 = 10;
            int numero3 = 20;

            int suma = numero1 + numero2 + numero3;
            Console.WriteLine("El valor de suma es:" + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
