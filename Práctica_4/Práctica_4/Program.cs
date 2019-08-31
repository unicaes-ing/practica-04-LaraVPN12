using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo, total=0.0;
            for (int i = 1; i <=20; i++)
			{
                sueldo=0.0;
                Console.WriteLine("Ingrese el sueldo del trabajador # {0}",i);
                sueldo=Convert.ToDouble(Console.ReadLine());
                total+=sueldo;
			}
            Console.WriteLine("Total de sueldos: {0:C2}",total);
            Console.WriteLine("Promedio de sueldos: {0:C2}",total/20);
            Console.ReadKey();
        }
    }
}
