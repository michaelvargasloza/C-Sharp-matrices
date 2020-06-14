using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila;
            int columna;

            int[,] mat;

            int max;
            int min;

            Console.Write("Ingrese la cantidad de filas: ");
            fila = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            columna = Convert.ToInt32(Console.ReadLine());

            mat = new int[fila, columna];

            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    Console.Write("Ingrese la posicion [" + (f + 1) + "," + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }

            max = 0;
            min = mat[0, 0];

            Console.Write("\nElementos de la matriz: \n");

            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    if (max <= mat[f, c])
                    {
                        max = mat[f, c];
                    }
                    if (mat[f, c] <= min)
                    {
                        min = mat[f, c];
                    }
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("\nNumero maximo: " + max);
            Console.Write("\nNumero minimo: " + min);

            Console.ReadLine();
        }
    }
}
