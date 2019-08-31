using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_4
{
    class Práctica_4_6
    {
        static void Main(string[] args)
        {
            int contador=1,cantidad,j=0;
            double precio=0,total=0.0,total1=0.0,TOTAL=0.0;
           
            Console.WriteLine("Ingrese la cantidad de Sucursales:");
            cantidad = Convert.ToInt32(Console.ReadLine());
            
            while (cantidad != 0)
            {

                do
                {
                    for (int i = 1; i <= cantidad; i++)
                    {
                        for (j = 1; j <= 3; j++)
                        {
                            Console.WriteLine("Ingrese el monto de la venta #{0} de la sucursal #{1}", j, i);
                            precio = Convert.ToDouble(Console.ReadLine());
                            if (precio == 0)
                            {
                                j = 4;
                                i = cantidad + 1;
                            }
                            if (j >= 1 && j <= 3)
                            {
                                total += precio;
                            }
                        }
                        TOTAL += total;
                        total1 = total / 3;
                        
                        Console.WriteLine("\nTotal sucuarsal {0}: {1:C2}", i,total);
                        Console.WriteLine("Promedio sucursal {0}: {1:C2}\n", i,total1);
                    }
                    contador=contador-2;
                } while (contador != -1);
                Console.WriteLine("Total global: {0:C2}",TOTAL);
                TOTAL /= (cantidad*3);
                Console.WriteLine("Promedio global: {0:C2}", TOTAL);
                cantidad = 0;
            }
            
            Console.ReadKey();
            

           
            
        }
    }
}
