using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            mat = new int[4, 5];

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write("Ingrese la posicion [" + (f + 1) + "," + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
            Console.Write("\nElementos de la matriz: \n");

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
