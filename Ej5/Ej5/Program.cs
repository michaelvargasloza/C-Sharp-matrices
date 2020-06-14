using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat1;
            double[,] mat2;
            double[,] mat3;

            mat1 = new double[3, 4];
            mat2 = new double[3, 4];
            mat3 = new double[3, 4];

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("Ingrese la posicion [" + (f + 1) + "," + (c + 1) + "] de la matriz 1: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat1[f, c] = int.Parse(linea);
                }
            }

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("Ingrese la posicion [" + (f + 1) + "," + (c + 1) + "] de la matriz 2: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat2[f, c] = int.Parse(linea);
                }
            }

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    mat3[f, c] = mat1[f, c] + mat2[f, c];
                }
            }

            Console.Write("\nElementos de la matriz 1: \n");

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(mat1[f, c] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("\nElementos de la matriz 2: \n");

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(mat2[f, c] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("\nElementos de la matriz resultante: \n");

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(mat3[f, c] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
