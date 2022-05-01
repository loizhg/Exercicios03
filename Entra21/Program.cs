using System;
namespace Luiz
{

    public class Program
    {
        public static void Main()
        {
            string letra;

            Console.WriteLine("Insira uma letra: ");
            letra = Convert.ToString(Console.ReadLine());


            Console.WriteLine($"A letra digitada foi: {letra}");

            int i;
            bool resultNumero = int.TryParse(letra, out i);
            if (resultNumero)
            {
                Console.WriteLine("Você digitou um numero bobão!!");
                return;
            }


            char n;
            bool resultChar = char.TryParse(letra, out n);
            if (resultChar)
            {
                Console.WriteLine("É um char");

                if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
                {
                    Console.WriteLine("É uma vogal!");
                }
                else
                {
                    Console.WriteLine("É uma consoante!");
                }


            }
            else
            {
                Console.WriteLine("Não é um char, rode o codigo novamente!");
            }

        }
    }
}