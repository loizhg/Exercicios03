using System;
namespace Luiz
{

    public class Program
    {
        public static void Main()
        {
            double a = 0, b = 0, c = 0,
                vx = 0, vy = 0,

                x1 = 0, x2 = 0;

            double delta;

            Console.WriteLine("insira o valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira o valor de b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira o valor de c: ");
            c = Convert.ToInt32(Console.ReadLine());

            delta = (b * b) - (4 * a * c);



            double raiz = Math.Sqrt(delta);

            if (delta < 0)
            {
                Console.WriteLine("Esta equação não possui raizes reais");
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                vx = x1;
            }
            else
            {
                x1 = (-b + raiz) / (2 * a);
                x2 = (-b - raiz) / (2 * a);

                vx = -b / (2 * a);
                vy = a * vx * vx + b * vx + c;

                if (a < 0)
                {
                    Console.WriteLine("O delta é menor que Zero");
                }
                else
                {
                    Console.WriteLine("O delta é maior que Zero");
                }

            }

            Console.WriteLine("Valor do vertice de X é: {0}", vx);
            Console.WriteLine("O valor do vertice de Y é: {0}", vy);

            Console.WriteLine("Valor de X': {0}", x1);
            Console.WriteLine("Valor de X'': {0}", x2);


        }
    }
}