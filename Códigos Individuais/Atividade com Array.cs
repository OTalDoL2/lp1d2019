using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp10
{
    class Program
    {
        //Procedimento da Q05
        static void MostrarArray(int[] repetirArray) 
        {
            for (int i = 0; i < repetirArray.Length; i++)
            {
                Console.WriteLine(repetirArray[i]);
            }
        }

        //Fun��o da Q06
        static int MostrarTudo(int[] Mostrando) 
        {
            int result = (Mostrando[0] + Mostrando[1] + Mostrando[2]);
            return result;
        }

        //Procedimento da Q07
        static void QuestEstranha(int[] Estranha, int a, int b) 
        {

            for (int i = 0; i < Estranha.Length; i++)
            {

                if (Estranha[i] > a && Estranha[i] < b)
                {
                    if (Estranha[i] % 2 == 1)
                    {
                        Thread.Sleep(900);
                        Console.WriteLine(Estranha[i]);
                    }
                }
                else
                {
                    continue;
                }
            }

        }

        //Fun��o da Q08
        static int[] TransformandoArray(int a, int b, int c) 
        {
            int[] NovoArray = new int[] { a, b, c };
            return NovoArray;
        }

        static void Main(string[] args)
        {
            //Quest 01            
                int numVez = 1;
                int numIndex = 0;
                Console.Write("Digite o " + numVez + "� n�mero, que eu colocarei no index {" + numIndex + "} ");
                int numInt0 = int.Parse(Console.ReadLine());
                numVez++;
                numIndex++;
                Console.Write("Digite o " + numVez + "� n�mero, que eu colocarei no index {" + numIndex + "} ");
                int numInt1 = int.Parse(Console.ReadLine());
                numVez++;
                numIndex++;
                Console.Write("Digite o " + numVez + "� n�mero, que eu colocarei no index {" + numIndex + "} ");
                int numInt2 = int.Parse(Console.ReadLine());
                numVez++;
                numIndex++;
                Console.Write("Digite o " + numVez + "� n�mero, que eu colocarei no index {" + numIndex + "} ");
                int numInt3 = int.Parse(Console.ReadLine());
                numVez++;
                numIndex++;
                Console.Write("Digite o " + numVez + "� n�mero, que eu colocarei no index {" + numIndex + "} ");
                int numInt4 = int.Parse(Console.ReadLine());
                numVez++;
                numIndex++;
                Thread.Sleep(1200);
                Console.Clear();

                int[] tester = new int[5];
                {
                    tester[0] = numInt0;
                    tester[1] = numInt1;
                    tester[2] = numInt2;
                    tester[3] = numInt3;
                    tester[4] = numInt4;
                }

                for (int i = 0; i < tester.Length; i++)
                {
                    Console.WriteLine("O n�mero digitado no index[" + i + "] = " + tester[i]);
                }
            
            //Quest02
                Console.WriteLine("Digite as notas que o aluno tirou, e eu direi a m�dia dele e se ele passou m�dia = 6 .");
                Console.Write("Nota 1: ");
                double notas = double.Parse(Console.ReadLine());
                Console.Write("Nota 2: ");
                double notas2 = double.Parse(Console.ReadLine());
                Console.Write("Nota 3: ");
                double notas3 = double.Parse(Console.ReadLine());
                Console.Write("Nota 4: ");
                double notas4 = double.Parse(Console.ReadLine());


                double[] notasDoAluno = new double[4];
                {
                    notasDoAluno[0] = notas;
                    notasDoAluno[1] = notas2;
                    notasDoAluno[2] = notas3;
                    notasDoAluno[3] = notas4;
                }


                double media = ((notasDoAluno[0] + notasDoAluno[1] + notasDoAluno[2] + notasDoAluno[3]) / 4);
                if (media >= 6)
                {
                    Console.WriteLine("O Aluno passou, pois o mesmo tirou " + media + " na m�dia.");
                }
                else
                {

                    Console.WriteLine("O Aluno n�o passou, pois o mesmo tirou " + media + " na m�dia.");
                }
            
            //Quest03
                int lista0 = int.Parse(Console.ReadLine());
                int lista1 = int.Parse(Console.ReadLine());
                int lista2 = int.Parse(Console.ReadLine());
                int lista3 = int.Parse(Console.ReadLine());
                int lista4 = int.Parse(Console.ReadLine());
                int lista5 = int.Parse(Console.ReadLine());
                int lista6 = int.Parse(Console.ReadLine());
                int lista7 = int.Parse(Console.ReadLine());
                int lista8 = int.Parse(Console.ReadLine());
                int lista9 = int.Parse(Console.ReadLine());
                int lista10 = int.Parse(Console.ReadLine());
                int lista11 = int.Parse(Console.ReadLine());
                int lista12 = int.Parse(Console.ReadLine());
                int lista13 = int.Parse(Console.ReadLine());
                int lista14 = int.Parse(Console.ReadLine());            
                int[] lista = new int[15];
                    lista[0] = lista0;
                    lista[1] = lista1;
                    lista[2] = lista2;
                    lista[3] = lista3;
                    lista[4] = lista4;
                    lista[5] = lista5;
                    lista[6] = lista6;
                    lista[7] = lista7;
                    lista[8] = lista8;
                    lista[9] = lista9;
                    lista[10] = lista10;
                    lista[11] = lista11;
                    lista[12] = lista12;
                    lista[13] = lista13;
                    lista[14] = lista14;            
                for (int index = 0; index < lista.Length; index++)
                {
                    if (lista[index] == 5)
                    {
                        Console.WriteLine("o Valor 5 est� na gaveta " + index);
                    }
                    else
                    {
                        continue;
                    }
                }
            
            //Quest 04
                int ValorArrA = int.Parse(Console.ReadLine());
                int[] ArrayA = new int[1];                    
                        ArrayA[0] = ValorArrA;                    
                int ValorArrB = int.Parse(Console.ReadLine());
                int[] ArrayB = new int[1];                    
                        ArrayB[0] = ValorArrB;                    
                int[] ArrayC = new int[1];                    
                        ArrayC[0] = (ArrayA[0] * ArrayB[0]);
                    
            
            //Quest 05
            
                int ValorRepetir = int.Parse(Console.ReadLine());
                int ValorRepetir2 = int.Parse(Console.ReadLine());
                int ValorRepetir3 = int.Parse(Console.ReadLine());
                int[] repetirArray = new int[] { ValorRepetir, ValorRepetir2, ValorRepetir3 };
                MostrarArray(repetirArray);
            
            //Quest 06
            
                Console.WriteLine("Digite os 3 n�mero que, eu mostrarei eles, e sua localiza��o nos Arrays.");
                Console.Write("O Primeiro N�mero � ");
                int Mostrar = int.Parse(Console.ReadLine());
                Console.Write("O Segundo N�mero � ");
                int Mostrar2 = int.Parse(Console.ReadLine());
                Console.Write("O Terceiro N�mero � ");
                int Mostrar3 = int.Parse(Console.ReadLine());
                int[] ArrQuest06 = new int[] { Mostrar, Mostrar2, Mostrar3 };
                MostrarTudo(ArrQuest06);
            
            //Quest 07
            
                Console.WriteLine("Digite dois n�meros que ser�o usados como refer�nciais. Sendo ambos positivos e iguais ou menores que 20.\nOBS.: 1� n�mero deve ser menor que o segundo.");
                Console.Write("Primeiro N�mero Referencial: ");
                int numRef1 = int.Parse(Console.ReadLine());
                Console.Write("Segundo N�mero Referencial: ");
                int numRef2 = int.Parse(Console.ReadLine());
                int[] ArrayEstranho = new int[20];
                ArrayEstranho[0] = 1;
                ArrayEstranho[1] = 2;
                ArrayEstranho[2] = 3;
                ArrayEstranho[3] = 4;
                ArrayEstranho[4] = 5;
                ArrayEstranho[5] = 6;
                ArrayEstranho[6] = 7;
                ArrayEstranho[7] = 8;
                ArrayEstranho[8] = 9;
                ArrayEstranho[9] = 10;
                ArrayEstranho[10] = 11;
                ArrayEstranho[11] = 12;
                ArrayEstranho[12] = 13;
                ArrayEstranho[13] = 14;
                ArrayEstranho[14] = 15;
                ArrayEstranho[15] = 16;
                ArrayEstranho[16] = 17;
                ArrayEstranho[17] = 18;
                ArrayEstranho[18] = 19;
                ArrayEstranho[19] = 20;
                Console.Clear();
                Console.WriteLine("\n{x (pertence) R | a < x < b}");
                Console.WriteLine("Todos os n�meros �mpares existentes entre os n�meros " + numRef1 + " e " + numRef2 + " s�o: ");
                Thread.Sleep(1500);
                QuestEstranha(ArrayEstranho, numRef1, numRef2);
            
            //Quest 08            
                int var1 = int.Parse(Console.ReadLine());
                int var2 = int.Parse(Console.ReadLine());
                int var3 = int.Parse(Console.ReadLine());
                TransformandoArray(var1, var2, var3);
            
        }
    }
}
