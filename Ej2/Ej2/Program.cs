using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mat;
            mat = new string[6, 5];

            mat[0, 0] = "Distrito/Candidato";
            mat[0, 1] = "Candidato A";
            mat[0, 2] = "Candidato B";
            mat[0, 3] = "Candidato C";
            mat[0, 4] = "Candidato D";

            mat[1, 0] = "Distrito 1";
            mat[1, 1] = "194";
            mat[1, 2] = "48";
            mat[1, 3] = "206";
            mat[1, 4] = "45";

            mat[2, 0] = "Distrito 2";
            mat[2, 1] = "180";
            mat[2, 2] = "20";
            mat[2, 3] = "320";
            mat[2, 4] = "16";

            mat[3, 0] = "Distrito 3";
            mat[3, 1] = "221";
            mat[3, 2] = "90";
            mat[3, 3] = "140";
            mat[3, 4] = "20";

            mat[4, 0] = "Distrito 4";
            mat[4, 1] = "432";
            mat[4, 2] = "50";
            mat[4, 3] = "821";
            mat[4, 4] = "14";

            mat[5, 0] = "Distrito 5";
            mat[5, 1] = "820";
            mat[5, 2] = "61";
            mat[5, 3] = "946";
            mat[5, 4] = "18";

            int[] votosPorCandidato;
            votosPorCandidato = new int[4];

            string[] candidato;
            candidato = new string[4];

            Console.Write("\nResultados de las elecciones: \n");

            for (int f = 0; f < 6; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }

            //Console.Write("\nTotal de votos por candidato: \n");

            int sum;
            sum = 0;

            int totalVotos;
            totalVotos = 0;

            for (int f = 1; f < 5; f++)
            {
                for (int c = 1; c < 6; c++)
                {
                    sum = sum + Convert.ToInt32(mat[c, f]);
                }                
                //Console.WriteLine("Votos para el candidato " + f + ": " + sum);
                votosPorCandidato[(f - 1)] = sum;
                candidato[(f - 1)] = mat[0, (f)];
                totalVotos = totalVotos + sum;
                sum = 0;
            }

            Console.WriteLine("\nTotal de los votos: " + totalVotos);
            Console.WriteLine("Votos necesarios para ganar: " + (totalVotos / 2) + " (50%)\n");

            int cont2;
            int tot2;

            cont2 = 0;
            tot2 = 3;

            int masVotados;
            masVotados = 0;

            while (cont2 <= tot2) {
                if (votosPorCandidato[cont2] > (totalVotos / 2))
                {
                    masVotados = masVotados + 1;
                }
                cont2 = cont2 + 1;
            }

            Array.Sort(votosPorCandidato, candidato);
            PrintKeysAndValues(votosPorCandidato, candidato);

            if (masVotados == 1)
            {
                Console.WriteLine("¡Gano el " + candidato[3] + " con " + votosPorCandidato[3] + " votos habiendo superado el 50%!");
            }
            else {
                Console.WriteLine("Los dos candidatos con más votos son:");
                Console.WriteLine("\n" + candidato[2] + " con " + votosPorCandidato[2] + " votos.");
                Console.WriteLine("\n" + candidato[3] + " con " + votosPorCandidato[3] + " votos.");
            }

            //Console.WriteLine("[{0}]", string.Join(", ", votosPorCandidato));
            //Console.WriteLine("[{0}]", string.Join(", ", candidato));

            Console.ReadLine();
        }

        public static void PrintKeysAndValues(int[] votosPorCandidato, String[] candidato)
        {
            //https://docs.microsoft.com/es-es/dotnet/api/system.array.sort?view=netcore-3.1#System_Array_Sort_System_Array_System_Array_
            for (int i = 0; i < votosPorCandidato.Length; i++)
            {
                Console.WriteLine("{0,-10}: {1}", candidato[i], votosPorCandidato[i]);
            }
            Console.WriteLine();
        }
    }
}
