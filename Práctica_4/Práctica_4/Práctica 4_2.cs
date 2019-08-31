using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_4
{
    class Práctica_4_2
    {
        static void Main(string[] args)
        {
            double nota, asistencia;
            int aprobados=0, reprobados=0;
            for (int i = 1; i <= 10; i++)
            {
                nota = 0.0;
                asistencia = 0.0;
                Console.WriteLine("Ingrese la nota del estudiante # {0}", i);
                nota = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el procentaje de asistencia del estudiante # {0}", i);
                asistencia = Convert.ToDouble(Console.ReadLine());
                if (nota >= 7.0 && asistencia >= 75)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }
            Console.WriteLine("Aprobados: {0:N2}", aprobados);
            Console.WriteLine("Reprobados: {0:N2}", reprobados);
            Console.ReadKey();
        }
    }
}
