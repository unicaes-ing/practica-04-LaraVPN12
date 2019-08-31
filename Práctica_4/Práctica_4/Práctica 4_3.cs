using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_4
{
    class Práctica_4_3
    {
        static void Main(string[] args)
        {
            string nombre;
            int contador=0;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] == 'a' || nombre[i] == 'á' || nombre[i] == 'A' || nombre[i]=='Á')
                {
                    contador++;
                }
                if (nombre[i] == 'e' || nombre[i] == 'é' || nombre[i] == 'E' || nombre[i]=='É')
                {
                    contador++;
                }
                if (nombre[i] == 'i' || nombre[i] == 'í' || nombre[i] == 'I' || nombre[i] == 'Í')
                {
                    contador++;
                }
                if (nombre[i] == 'o' || nombre[i] == 'ó' || nombre[i] == 'O' || nombre[i] == 'Ó')
                {
                    contador++;
                } if (nombre[i] == 'u' || nombre[i] == 'ú' || nombre[i] == 'U' || nombre[i] == 'Ú')
                {
                    contador++;
                }

            }
            Console.WriteLine("La cantidad de vocales son: {0:N2}", contador);
            Console.ReadKey();
        }
    }
}
