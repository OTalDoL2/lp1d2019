
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_extra_de_procedimentps
{
    class Program
    {
        //Procedimentos

            //q01
                        static int Pot(int bas, int exp)
                        {
                            int result = 1;
                            for (int i = 0; i < exp; i++)
                            {
                                result = result * bas;
                            }
                            return result;
                        }
            //q02
                        static string ValorC(int a, int b, int c)
                        {
                            int d = (a + b);
                            string result;
                                if(d>c) { result = "maior"; }
                                else if(d==c) { result = "igual"; }                       
                                else { result = "menor"; }
                            return result;
                        }
            //q03
                        static double GrausC(double f)
                        {
                            double c;
                            c = (((f - 32)) * 5) / 9;
                            return c;
                        }
            //q04
                        static double TtCompra(double qntd)
                        {            
                            double m ;
                            if(qntd<12) { m = 1.30; }
                            else { m = 1.00; }
                            double Valor = (m*qntd);
                            return Valor;
                        }
            //q05
                        static string ABC(int a, int b, int c)
                        {
                            string result;
                            if (a + b > c && b + c > a && c + a > b )
                            { result = "� um tri�ngulo, pois cada um de seus lados � menor que a soma de seus outros dois."; }
                            else
                            { result = "n�o � um tri�ngulo um de seus lados � maior que a soma de seus outros dois."; }
                            return result;
                        }
            //q06
                        static int Media(int n1,int n2,int n3)
                        {
                            int Media = ((n1 * 2) + (n2 * 3) + (n3 * 5))/10;
                            return Media;
                        }

        static void Main(string[] args)
        {            
            int quest = int.Parse(Console.ReadLine());
            Console.Clear();
                switch (quest)
                {
                    case 1:
                            //q01           
                            Console.Write("O n�mero ");
                            int bas = int.Parse(Console.ReadLine());
                            System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(1));
                            Console.Clear();
                            Console.Write("O n�mero " + bas + " elevado a ");
                            int exp = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("O n�mero " + bas + " elevado a " + exp + " � igual a " + Pot(bas, exp));                    
                        break;
                    case 2:
                            //q02
                            Console.WriteLine("informe os valores de A,B e C");
                            Console.Write("A:");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("B:");
                            int b = int.Parse(Console.ReadLine());
                            Console.Write("C:");
                            int c = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("O valor de C � " + ValorC(a,b,c) + " do que a soma entre A e B.");
                        break;
                    case 3:
                            Console.WriteLine("Digite uma temperatura em Fahrenheit: ");
                            double f = double.Parse(Console.ReadLine());
                            Console.WriteLine(f + "�F equivale a " + GrausC(f) + "�C.");
                        break;

                    case 4:
                            Console.WriteLine("Quantas ma��s voc� deseja comprar? ");
                            Console.Write("Eu quero comprar ");
                            double m = double.Parse(Console.ReadLine());
                            Console.Clear();
                            string bs;
                            if (m>1) { bs = "am R$"; }
                            else { bs = "a R$"; }
                            Console.WriteLine(m + " ma��s cust" + bs + TtCompra(m) );
                        break;
                    case 5:
                            Console.WriteLine("D� os valores A, B e C, para dizer se ABC � um Tri�ngulo.");
                            Console.Write("A = ");
                            int LadoA = int.Parse(Console.ReadLine());
                            Console.Write("B = ");
                            int LadoB = int.Parse(Console.ReadLine());
                            Console.Write("C = ");
                            int LadoC = int.Parse(Console.ReadLine());
                            Console.WriteLine("ABC " + ABC(LadoA,LadoB,LadoC) );
                        break;
                    case 6:
                            Console.WriteLine("Digite suas notas, respeitando a ordem de pesos: 2,3 e 5.");
                            Console.Write("Nota 1: ");
                            int n1 = int.Parse(Console.ReadLine());
                            Console.Write("Nota 2: ");
                            int n2 = int.Parse(Console.ReadLine());
                            Console.Write("Nota 3: ");
                            int n3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Sua m�dia � " + Media(n1,n2,n3));
                        break;


                }
        }
    }
}
