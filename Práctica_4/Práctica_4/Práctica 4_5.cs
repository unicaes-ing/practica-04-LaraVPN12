using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_4
{
    class Práctica_4_5
    {
        static void Main(string[] args)
        {
            string contraseña = "Hola",clave="";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese la contraseña");
                clave = Console.ReadLine();
                if (clave != contraseña)
                {
                    Console.WriteLine();
                    Console.WriteLine("Pista:");
                    Console.WriteLine(contraseña[i]+"\n");
                }
            }
            Console.WriteLine("Sus intentos se agotaron");
            Console.ReadKey();
            
        }
    }
}
