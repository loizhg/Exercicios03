using System;

namespace senac
{
    class Program
    {
        public static void Main()
        {

            int ano;
            int anoDe4;
            int anoDe400;



            Console.WriteLine("insira o ano: ");
            ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("o ano digitado é: " + ano);

            anoDe4 = (ano / 4);
            anoDe400 = (ano / 400);

            Console.WriteLine("o ano dividido por 4 é: " + anoDe4);
            Console.WriteLine("o ano dividido por 4 é: " + anoDe400);

            if (anoDe4 % 100 == 0)
            {
                Console.WriteLine("Número é divisivel por 4.");
                if (anoDe400 % 100 == 0)
                {
                    Console.WriteLine("Número é divisivel por 400.");
                    Console.WriteLine("Contudo, o ano é bissesto");
                }
                else
                {
                    Console.WriteLine("Número não é divisivel por 400.");
                }
            }


            else
            {
                Console.WriteLine("Número não é divisivel por 4.");
            }



        }
    }
}







