using System;
namespace Luiz
{

    public class Program
    {
        public static void Main()
        {

            decimal[] numeros = new decimal[3];
            int contador = 0;

            decimal menor = 0, maior = 0, posicao_menor = 0, posicao_maior = 0;
            decimal meio = 0, posicao_meio = 0;

            //colocar em ordem crescente usando if
            for (int p = 0; p < numeros.Length; p++)
            {
                Console.Write("Digite um numero: " + p +);
                numeros[p] = Convert.ToDecimal(Console.ReadLine());
                decimal valor = numeros[p];
                contador++;
                if (p == 0)
                {
                    menor = numeros[0];
                    maior = numeros[0];
                }

                if (numeros[p] < menor)
                {

                    menor = numeros[p];
                    posicao_menor = p;

                }
                else if (numeros[p] > maior)
                {
                    maior = numeros[p];
                    posicao_maior = p;
                }
                else
                {
                    meio = numeros[p];
                    posicao_meio = p;
                }
            }


            //Array.Sort(numeros);
            Console.Write("\n\n");
            Console.WriteLine("Estes foram os numeros digitados: ");
            foreach (decimal p in numeros) Console.WriteLine(p);



            Console.WriteLine("O menor número é:" + menor);
            Console.WriteLine("A posição do menor número é:" + posicao_menor);

            Console.WriteLine("O número do meio é:" + meio);
            Console.WriteLine("A posição do maior número é:" + posicao_meio);

            Console.WriteLine("O maior número é:" + maior);
            Console.WriteLine("A posição do maior número é:" + posicao_maior);
        }
    }
}
