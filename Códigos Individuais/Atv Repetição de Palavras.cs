using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp1d04092019
{
    class Program
    {
        //Quest 10 - Mostrar quantas vezes a palavra ANA aparece na frase "ANA E MARIANA GOSTAM DE BANANA"
	//OBS: o c�digo s� funciona com essa frase, por enquanto. Caso consiga fazer um algoritmo que funcione independente da frase, me avisa ;)


        static int Ocorrencia(char[] FraseMenor, char[] FraseMaior)
        {
            int cont = 0;
            for (int index = 0; index < FraseMaior.Length; index++)
            {

                if (FraseMaior[index] == FraseMenor[0])
                {
                    cont++;
                }
                else
                {
                    continue;
                }
            }

            int cont2 = 0;
            for (int index = 1; index < FraseMaior.Length; index++)
            {
                if (FraseMaior[index] == FraseMenor[1])
                {
                    cont2++;
                }
                else
                {
                    continue;
                }
            }
            int result = (cont + cont2) / 3;
            return result;
        }


        //Quest 15
        static void Valorfixo(int[] NumFixo, int Par, int Impar)
        {
            if (NumFixo[0] > Par)
            {
                Console.WriteLine("Crescente: " + Par + " " + NumFixo[0]);
            }
            else
            {
                Console.WriteLine("Crescente: " + NumFixo[0] + " " + Par);
            }

            if (NumFixo[1] < Impar)
            {
                Console.WriteLine("Decrescente: " + Impar + " " + NumFixo[1]);
            }
            else
            {
                Console.WriteLine("Decrescente: " + NumFixo[1] + " " + Impar);
            }
        }


        

        static void Main(string[] args)
        {
            //Quest�o 10
            char[] Nome1 = new char[2];
            Nome1[0] = 'A';
            Nome1[1] = 'N';
            

            char[] Nome2 = new char[25];
            Nome2[0] = 'A';
            Nome2[1] = 'N';
            Nome2[2] = 'A';

            Nome2[3] = 'E';

            Nome2[4] = 'M';
            Nome2[5] = 'A';
            Nome2[6] = 'R';
            Nome2[7] = 'I';
            Nome2[8] = 'A';
            Nome2[9] = 'N';
            Nome2[10] = 'A';

            Nome2[11] = 'G';
            Nome2[12] = 'O';
            Nome2[13] = 'S';
            Nome2[14] = 'T';
            Nome2[15] = 'A';
            Nome2[16] = 'M';

            Nome2[17] = 'D';
            Nome2[18] = 'E';

            Nome2[19] = 'B';
            Nome2[20] = 'A';
            Nome2[21] = 'N';
            Nome2[22] = 'A';
            Nome2[23] = 'N';
            Nome2[24] = 'A';


            Console.WriteLine("A plavra \"ANA\" est� presente na frase \"ANA E MARIANA GOSTAM DE BANANA\" " + Ocorrencia(Nome1, Nome2) + " vezes");

            Console.ReadKey();
            Console.Clear();

            // QUest�o 15
            int[] NumFixo = new int[2];
            NumFixo[0] = 2;
            NumFixo[1] = 7;
            Console.WriteLine("Os n�meros fixos s�o 2 e 7, respectivamente.");
            Console.Write("Digite um n�mero Par:");
            int Par = int.Parse(Console.ReadLine());
            Console.Write("Digite um n�mero �mpar");
            int Impar = int.Parse(Console.ReadLine());
            Valorfixo(NumFixo, Par, Impar);






        }
    }
}


























using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("digite dez numeros");
            //int[] array1 = new int[10];
            //array1[0] = int.Parse(Console.ReadLine());
            //array1[1] = int.Parse(Console.ReadLine());
            //array1[2] = int.Parse(Console.ReadLine());
            //array1[3] = int.Parse(Console.ReadLine());
            //array1[4] = int.Parse(Console.ReadLine());
            //array1[5] = int.Parse(Console.ReadLine());
            //array1[6] = int.Parse(Console.ReadLine());
            //array1[7] = int.Parse(Console.ReadLine());
            //array1[8] = int.Parse(Console.ReadLine());
            //array1[9] = int.Parse(Console.ReadLine());

            //int contador = 0;

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    for (int j = i + 1; j < array1.Length; j++)
            //    {
            //        if (j != i && array1[j] == array1[i])
            //        {
            //            contador++;
            //            break;
            //        }
            //    }
            //}



            //var result = (from n in array1
            //              where array1.Count(n1 => n1 == n) >= 2
            //              select n).Distinct();
            //foreach (int num in result)
            //    Console.WriteLine("O numero {0} � repetido {1}", num, contador);

            Console.Write("Qnts letras vai ter na palavra?");
            int qntdLetra01 = int.Parse(Console.ReadLine());
            Console.Write("Qnts letras vai ter na frase?");
            int qntdLetra02 = int.Parse(Console.ReadLine());

            char[] Nome1 = new char[qntdLetra01];
            for (int i = 0; i < Nome1.Length; i++)
            {
                Nome1[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("o 2 ");
            char[] Nome2 = new char[qntdLetra02];
            for (int i = 0; i < Nome2.Length; i++)
            {
                Nome2[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine(Ocorrencia(Nome1, Nome2));

        }
        static int Ocorrencia(char[] FraseMenor, char[] FraseMaior)
        {
            int cont = 0;
            for (int index = 0; index < FraseMaior.Length; index++)
            {
               
            }

            int result = (cont) / FraseMenor.Length;
            return result;

        }

    }

}
