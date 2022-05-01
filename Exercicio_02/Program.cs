using System;

public class Program
{
    public static void Main()
    {

        decimal ladoA;
        decimal ladoB;
        decimal ladoC;

        decimal ladobc;
        decimal ladoac;
        decimal ladoab;

        decimal ladoBC;
        decimal ladoAC;
        decimal ladoAB;

        bool positivoA;
        bool positivoB;
        bool positivoC;

        positivoA = false;
        positivoB = false;
        positivoC = false;

        Console.WriteLine("insira o lado A: ");
        ladoA = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("insira o lado B: ");
        ladoB = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("insira o lado C: ");
        ladoC = Convert.ToDecimal(Console.ReadLine());


        ladobc = ladoB - ladoC;
        ladoac = ladoA - ladoC;
        ladoab = ladoA - ladoB;


        ladoBC = ladoB + ladoC;
        ladoAC = ladoA + ladoC;
        ladoAB = ladoA + ladoB;

        if (ladobc < ladoA & ladoA < ladoBC)
        {
            positivoA = true;
        }
        if (ladoac < ladoB & ladoB < ladoAC)
        {
            positivoB = true;
        }
        if (ladoab < ladoC & ladoC < ladoAB)
        {
            positivoC = true;
        }





        if (positivoA == true & positivoB == true & positivoC == true)
        {
            bool equilatero;
            bool isosceles;
            bool escaleno;

            equilatero = false;
            isosceles = false;
            escaleno = false;

            //equilatero
            if (ladoA == ladoB & ladoA == ladoC)
            {
                equilatero = true;
                Console.WriteLine("O triangulo é equilatero!");
            }

            //isoceles
            if (ladoA == ladoB & ladoB != ladoC)
            {
                isosceles = true;
                Console.WriteLine("O triangulo é isosceles!");
            }
            if (ladoA == ladoC & ladoB != ladoC)
            {
                isosceles = true;
                Console.WriteLine("O triangulo é isosceles!");
            }
            if (ladoB == ladoC & ladoA != ladoC)
            {
                isosceles = true;
                Console.WriteLine("O triangulo é isosceles!");
            }

            //escaleno
            if (ladoA != ladoB & ladoA != ladoC & ladoB != ladoC)
            {
                escaleno = true;
                Console.WriteLine("O triangulo é escaleno!");
            }
            Console.WriteLine("O triangulo existe!");
        }
        else
        {
            Console.WriteLine("O triangulo não existe!");
        }

        if (ladoA == ladoB)
        {

        }







    }
}