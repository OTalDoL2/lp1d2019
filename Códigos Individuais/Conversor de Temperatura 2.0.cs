using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Conversor_de_Temperaturas_2._0
{
    class Program
    {
        static double CelciusFahr(double temp, double num)          //case 1 e 2
        {            
            double f;
            double c;
            if (num == 1 ) //c para f
            {
                
                f = temp * 9 / 5 + 32;
                return f;
            }
            else //f para c
            {
                c = ((temp - 32) * 5 / 9);
                return c;
            }
        }

        static double KelvinFahr(double temp, double num)          //case 3 e 4  
        {
            double f;
            double k;
            if (num == 3) //f para k
            {

                k = ((temp - 32) * 5 / 9 + 273.15);
                return k;
            }
            else //k para f
            {
                f = ((temp - 273.15) * 9 / 5 + 32);
                return f;
            }
        }
        static double CelsiusKelvin(double temp, double num)            //case 5 e 6
        {
            double c;
            double k;
            if(num == 5) //k para c
            {
                c = (temp - 273.15);
                return c;
            }
            else  //c para k
            {
                k = temp + 273.15;
                return k;
            }
        }


        static void Main(string[] args)
        {
            //introdução
            Console.WriteLine("Primeiramente coloque o programa em TELA CHEIA");
            Thread.Sleep(8000);
            Console.Clear();

            Console.WriteLine("Seja bem-vindo ao \n\n");
                Thread.Sleep(5000);
            Console.WriteLine("					 ::::::::     ::::::::    ::::    :::   :::     :::  ::::::::::  :::::::::    ::::::::    ::::::::   :::::::::  ");
                Thread.Sleep(800);
            Console.WriteLine("					:+:    :+:   :+:    :+:   :+:+:   :+:   :+:     :+:  :+:         :+:    :+:  :+:    :+:  :+:    :+:  :+:    :+: ");
                Thread.Sleep(800);
            Console.WriteLine("					+:+          +:+    +:+   :+:+:+  +:+   +:+     +:+  +:+         +:+    +:+  +:+         +:+    +:+  +:+    +:+ ");
                Thread.Sleep(800);
            Console.WriteLine("					+#+          +#+    +:+   +#+ +:+ +#+   +#+     +:+  +#++:++#    +#++:++#:   +#++:++#++  +#+    +:+  +#++:++#:  ");
                Thread.Sleep(800);
            Console.WriteLine("					+#+          +#+    +#+   +#+  +#+#+#    +#+   +#+   +#+         +#+    +#+         +#+  +#+    +#+  +#+    +#+ ");
                Thread.Sleep(800);
            Console.WriteLine("					#+#    #+#   #+#    #+#   #+#   #+#+#     #+#+#+#    #+#         #+#    #+#  #+#    #+#  #+#    #+#  #+#    #+# ");
                Thread.Sleep(800);
            Console.WriteLine("				 	 ########     ########    ###    ####       ###      ##########  ###    ###   ########    ########   ###    ### ");
                Thread.Sleep(800);
            Console.WriteLine("\n");
                Thread.Sleep(800);
            Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(800);
            Console.WriteLine("										:::::::::   :::::::::: ");
                Thread.Sleep(800);
            Console.WriteLine("										:+:    :+:  :+:        ");
                Thread.Sleep(800);
            Console.WriteLine("										+:+    +:+  +:+        ");
                Thread.Sleep(800);
            Console.WriteLine("										+#+    +:+  +#++:++#   ");
                Thread.Sleep(800);
            Console.WriteLine("										+#+    +#+  +#+        ");
                Thread.Sleep(800);
            Console.WriteLine("										#+#    #+#  #+#        ");
                Thread.Sleep(800);
            Console.WriteLine("										#########   ########## ");
                Thread.Sleep(800);
            Console.WriteLine("\n");
                Thread.Sleep(800);
            Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
            Console.WriteLine("			:::::::::::  ::::::::::  ::::    ::::   :::::::::   ::::::::::  :::::::::       :::      :::::::::::  :::    :::  :::::::::       :::     ");
                Thread.Sleep(800);
            Console.WriteLine("    			    :+:      :+:         +:+:+: :+:+:+  :+:    :+:  :+:         :+:    :+:    :+: :+:        :+:      :+:    :+:  :+:    :+:    :+: :+:   ");
                Thread.Sleep(800);
            Console.WriteLine("    			    +:+      +:+         +:+ +:+:+ +:+  +:+    +:+  +:+         +:+    +:+   +:+   +:+       +:+      +:+    +:+  +:+    +:+   +:+   +:+  ");
                Thread.Sleep(800);
            Console.WriteLine("			    +#+      +#++:++#    +#+  +:+  +#+  +#++:++#+   +#++:++#    +#++:++#:   +#++:++#++:      +#+      +#+    +:+  +#++:++#:   +#++:++#++: ");
                Thread.Sleep(800);
            Console.WriteLine("			    +#+      +#+         +#+       +#+  +#+         +#+         +#+    +#+  +#+     +#+      +#+      +#+    +#+  +#+    +#+  +#+     +#+ ");
                Thread.Sleep(800);
            Console.WriteLine("			    #+#      #+#         #+#       #+#  #+#         #+#         #+#    #+#  #+#     #+#      #+#      #+#    #+#  #+#    #+#  #+#     #+# ");
                Thread.Sleep(800);
            Console.WriteLine("			    ###      ##########  ###       ###  ###         ##########  ###    ###  ###     ###      ###       ########   ###    ###  ###     ### ");
                Thread.Sleep(800);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(800);
            Console.WriteLine("										 ::::::::         :::::::  ");
                Thread.Sleep(800);
            Console.WriteLine("										:+:    :+:       :+:   :+: ");
                Thread.Sleep(800);
            Console.WriteLine("										      +:+        +:+  :+:+ ");
                Thread.Sleep(800);
            Console.WriteLine("										    +#+          +#+ + +:+ ");
                Thread.Sleep(800);
            Console.WriteLine("										  +#+            +#+#  +#+ ");
                Thread.Sleep(800);
            Console.WriteLine("										 #+#        #+#  #+#   #+# ");
                Thread.Sleep(800);
            Console.WriteLine("										##########  ###   #######                                                                              ");
                Thread.Sleep(800);
            
            //switch
            double C;
            double K;
            double F;

            for (int i = 0; i < 7; i++)
            {


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Se você quer converter de Celsius para Fahrenheit... digite 1 e aperte enter: ");
                Console.WriteLine(" Se você quer converter de Fahrenheit para Celsius... digite 2 e aperte enter: ");
                Console.WriteLine(" Se você quer converter de Fahrenheit para Kelvin... digite 3 e aperte enter: ");
                Console.WriteLine(" Se você quer converter de Kelvin para Fahrenheit... digite 4 e aperte enter: ");
                Console.WriteLine(" Se você quer converter de Kelvin para Celsius... digite 5 e aperte enter: ");
                Console.WriteLine(" Se você quer converter de Celsius para Kelvin... digite 6 e aperte enter: ");
                int num = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (num)
                {
                    case 1:
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1.37));
                        Console.Write("Digite um número em °C, que será convertido para Fahrenheit: ");
                        C = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(C + "°C é igual à " + CelciusFahr(C, num) + "°F");
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1.37));
                        Console.Write("Digite um número em °F, que será convertido em Graus Celsius: ");
                        F = Convert.ToDouble(Console.ReadLine());                        
                        Console.Write(F + "°F é igual à " + CelciusFahr(F,num) + "°C");
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Digite um número em °F, que será convertido em Kelvin: ");
                        F = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(F + "°F é igual à " + KelvinFahr(F, num) + " Kelvin");
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.86));
                        Console.WriteLine("Digite um número em Kelvin, que será convertido para Fahrenheit: ");
                        K = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(K + " Kelvin é igual à " + KelvinFahr(K,num) + "°F");
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.86));
                        Console.WriteLine("Digite um número em Kelvin, que será convertido para Graus Celsius:");
                        K = Convert.ToDouble(Console.ReadLine());
                        Console.Write(K + " Kelvin é igual à " + CelsiusKelvin(K,num) + "°C");
                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.86));
                        Console.WriteLine("Bem, e pra finalizar, Diga um número em Kelvin, para eu converter em Celsius.");
                        C = Convert.ToDouble(Console.ReadLine());                        
                        Console.Write(C + "°C é igual à " + CelsiusKelvin(C, num) + " Kelvin");                        
                        break;

                    default:
                        Console.WriteLine("Opa, parece que você digitou outro número, por favor selecione uma opção de 1 a 6");
                        break;

                }

                Console.Write("Obrigado pelo teste!!!!!!!!!!! ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("~L2 //Lucas M. de Oliveira 1º D");
            }

        }
    }
}
