using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat1;
            double[,] mat2;

            mat1 = new double[2, 3];
            mat2 = new double[2, 3];

            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("Ingrese la posicion [" + (f + 1) + "," + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat1[f, c] = int.Parse(linea);
                    mat2[f, c] = Math.Pow(int.Parse(linea), 2);
                }
            }

            Console.Write("\nElementos de la matriz: \n");

            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 3; c++)
                {                    
                    Console.Write(mat1[f, c] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("\nMatriz al cuadrado: \n");

            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(mat2[f, c] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
