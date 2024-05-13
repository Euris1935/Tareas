using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_del_Monto_en_base_al_pais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un Monto: ");
            double Monto = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Codigo del País: ");
            string codigo = Console.ReadLine();

            if (codigo == "DO")

            {
                Monto = Monto * 0.18 + Monto;
                Console.WriteLine("El Monto de DO es de: " + Monto);

            }
            if (codigo == "VZ")
            {
                Monto = Monto * 0.12 + Monto;
                Console.WriteLine("El Monto de VZ es de: " + Monto);
            }
            if (codigo == "CS")
            {
                Monto = Monto * 0.10 + Monto;
                Console.WriteLine("El Monto de CS es de: " + Monto);
            }

            Console.ReadLine();
        }
    }
}
