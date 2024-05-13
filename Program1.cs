using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_multiplicar_de_un_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Tabla de Multiplicacion de Numeros ********");

            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabla de multiplicar del : "+ numero);
            

            for (int i = 0; i < 13; i++)
            {
                  int resultado = numero * i;
                Console.WriteLine(numero + " x " + i + " = " + resultado);

            }

            Console.ReadLine();
        }

    }
}
