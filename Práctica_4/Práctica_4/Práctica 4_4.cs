using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_4
{
    class Práctica_4_4
    {
        static void Main(string[] args)
        {
            double ventas=0.0,total=0.0;
            int contador=0,cantidad=0;

            
            Console.WriteLine("Ingresa la cantidad de ventas");
            cantidad = Convert.ToInt32(Console.ReadLine());
            while (cantidad !=-1 && cantidad > 0)
            {
                for (int i = 1; i <=cantidad; i++)
                {
                    Console.WriteLine("Ingrese el monto de la venta {0}",i);
                    ventas = Convert.ToDouble(Console.ReadLine());
                    if (ventas !=1 && ventas>0)
                    {
                        total += ventas;
                        
                    }
                    else i = cantidad;
                }
                if (total >= 0)
                {
                    Console.WriteLine("Total de ventas: {0:C2}", total);
                    Console.WriteLine("Total + 5% de bono: {0:C2}", total + (total * 0.05));
                    Console.ReadKey();
                }
                
                cantidad = -2; 
            }
            if (cantidad == 0)
            {
                Console.WriteLine("No se realizaron ventas");
                Console.ReadKey();
            }
            
            
        }
    }
}
