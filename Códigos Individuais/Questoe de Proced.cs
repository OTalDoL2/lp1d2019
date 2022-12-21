using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando_procedimentos_e_funções
{
    class Program
    { 
        //Q01 -
        //static double PesoH(double h)
        //{
        //    double idealh = (72.7 * h) - 58;
        //    return idealh;
        //}
        //static double PesoM(double h)
        //{
        //    double idealm = (62.1 * h) - 44.7;
        //    return idealm;
        //}

        //static void Main(string[] args)
        //{
        //    //Tendo como parâmetros a altura e o sexo de uma pessoa(M - Masculino e F - Feminino), crie uma função que calcule o peso ideal de uma pessoa utilizando as seguintes fórmulas:
        //    //-para homens: (72.7 * h) - 58 - para mulheres: (62.1 * h) - 44.7
        //    Console.WriteLine("Você é Homem ou Mulher? ");
        //    string sexo = Console.ReadLine();
        //    if (sexo == "Homem" || sexo == "homem")
        //    {
        //        Console.Write("Qual sua altura? ");
        //        double altH = double.Parse(Console.ReadLine());
        //        Console.WriteLine("Seu peso ideal seria: " + PesoH(altH));
        //    }
        //    else
        //    {
        //        Console.Write("Qual sua altura? ");
        //        double altM = double.Parse(Console.ReadLine());
        //        Console.WriteLine("Seu peso ideal seria: " + PesoM(altM));
        //    }

        //    //Q02-
        //    Console.WriteLine("QUal procedimento você deseja realizar? ");
        //    int procedQ2 = int.Parse(Console.ReadLine());
        //    int i;
        //    int a;
        //    int b;
        //    int c;
        //    switch (procedQ2)
        //    {
        //        case 1:
        //            i = 1;
        //            a = int.Parse(Console.ReadLine());
        //            b = int.Parse(Console.ReadLine());
        //            c = int.Parse(Console.ReadLine());
        //            if (a > b && b > c)
        //            {
        //                Console.WriteLine("Crescente: " + a + ", " + b + " e " + c);
        //            }
        //            break;
        //        case 2:
        //            i = 2;
        //            a = int.Parse(Console.ReadLine());
        //            b = int.Parse(Console.ReadLine());
        //            c = int.Parse(Console.ReadLine());
        //            if (c > b && b > a)
        //            {
        //                Console.WriteLine("Decrescente: " + c + ", " + b + " e " + a);
        //            }
        //            break;
        //        case 3:
        //            i = 3;
        //            a = int.Parse(Console.ReadLine());
        //            b = int.Parse(Console.ReadLine());
        //            c = int.Parse(Console.ReadLine());
        //            if (i > a && a > b && b > c)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + i + " " + a );
        //            }
        //            else if (i > b && b > a && a > c)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + i + " " + b);
        //            }
        //            else if (i > b && b > c && c > a)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + i + " " + b);
        //            }
        //            else if (i > a && a > c && c > b)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + i + " " + a);
        //            }
        //            else if (i > c && c > a && a > b)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + i + " " + c);
        //            }
        //            else if (i > c && c > b && b > a)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + i + " " + c);
        //            }

        //            //2 
        //            else if (a > b && b > c && c > i)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + a + " " + b);
        //            }
        //            else if (a > c && c > b && b > i)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + a + " " + c);
        //            }
        //            else if (a > c && c > i && i > b)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + a + " " + c);
        //            }
        //            else if (a > b && b > i && i > c)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + a + " " + b);
        //            }
        //            else if (a > i && i > c && c > b)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + a + " " + i);
        //            }
        //            else if (a > i && i > b && b > c)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + a + " " + i);
        //            }
        //            //3
        //            else if (b > a && a > c && c > i)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + b + " " + a);
        //            }
        //            else if (b > a && a > i && i > c)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + b + " " + a);
        //            }
        //            else if (b > c && c > a && a > i)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + b + " " + c);
        //            }
        //            else if (b > c && c > i && i > a)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + b + " " + c);
        //            }
        //            else if (b > i && i > c && c > a)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + b + " " + i);
        //            }
        //            else if (b > i && i > a && a > c)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + b + " " + i);
        //            }
        //            //4
        //            else if (c > a && a > b && b > i)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + c + " " + a);
        //            }
        //            else if (c > a && a > i && i > b)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + c + " " + a);
        //            }
        //            else if (c > b && b > i && i > a)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + c + " " + b);
        //            }
        //            else if (c > b && b > a && a > i)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + c + " " + b);
        //            }
        //            else if (c > i && i > a && a > b)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + c + " " + i);
        //            }
        //            else if (c > i && i > b && b > a)
        //            {
        //                Console.WriteLine("Os dois maiores números são: " + c + " " + i);
        //            }
        //            break;
        //    }
        //}

        static string Eleicao( int AnoN)
        {
            string msg;
            int idade = (2019 - AnoN);
            if (idade >= 18)
            {
                msg = "Você é de maior";
            }
            else
            {
                msg = "Foi mal, mas você ainda não pode votar..., mas você poderá votar daqui à ";
            }
            return msg;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Ano que você nasceu.");
            int ano = int.Parse(Console.ReadLine());
            Eleicao(ano);
            
        }
    }
}























i > a && a > b && b > c
i > b && b > a && a > c
i > b && b > c && c > a
i > a && a > c && c > b

i > c && c > a && a > b
i > c && c > b && b > a



a > b && b > c && c > i
a > c && c > b && b > i
a > c && c > i && i > b
a > b && b > i && i > c
a > i && i > b && b > c
a > i && i > c && c > b

b > a && a > c && c > i
b > a && a > i && i > c
b > c && c > a && a > i
b > c && c > i && i > a
b > i && i > c && c > a
b > i && i > a && a > c

c > a && a > b && b > i
c > a && a > i && i > b
c > b && b > i && i > a
c > b && b > a && a > i
c > i && i > a && a > b
c > i && i > b && b > a




static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int numMenor = 0;
            int numMeio = 0;
            int numMaior = 0;
            if (a > b && a > c)
            {
                numMaior = a;     
                if (b>c)
                {
                    numMeio = b;
                    numMenor = c;
                }
                else
                {
                    numMeio = c;
                    numMenor = b;
                }
            }
            else if (b > a && b > c)
            {
                numMaior = b;
                if (a > c)
                {
                    numMeio = a;
                    numMenor = c;
                }
                else
                {
                    numMeio = c;
                    numMenor = a;
                }
            }
            else if (c > b && c > a)
            {
                numMaior = c;
                if (b > a)
                {
                    numMeio = b;
                    numMenor = a;
                }
                else
                {
                    numMeio = a;
                    numMenor = b;
                }
            }
            Console.WriteLine("Digite um valor para i.");
            Console.Write("i==");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {

            }

            Console.WriteLine(numMenor + " " + numMeio + " " + numMaior);
        }








