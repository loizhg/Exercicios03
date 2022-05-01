using System;

public class Program
{
	public static void Main()
	{

		double salario;
		double percentualAumento;
		double aumentoReal;
		double salarioNovo;


		//ADICIONAR M APOS A VARIAVEL exemplo
		//decimal real;
		//real = 4.70M;

		double dolar;
		dolar = 4.70;

		double euro;
		euro = 5.20;

		double conversaoDolar;
		double conversaoEuro;


		Console.WriteLine("Insira o salário do colaborador: ");
		salario = Convert.ToDouble(Console.ReadLine());



		if (salario <= 1200)
		{
			percentualAumento = 20;
			aumentoReal = (salario * percentualAumento) / 100;
			salarioNovo = salario + aumentoReal;



			Console.WriteLine("O salário do colaborador é é:" + salario);
			Console.WriteLine("O percentual é:" + percentualAumento);
			Console.WriteLine("O valor a se acrescentar é:" + aumentoReal);
			Console.WriteLine("O salário novo é:" + salarioNovo);

			conversaoDolar = salarioNovo / dolar;
			conversaoEuro = salarioNovo / euro;
			Console.WriteLine("O salário em dolar é:" + conversaoDolar);
			Console.WriteLine("O salário em euro é:" + conversaoEuro);



		}
		else if (salario > 1200 & salario <= 2000)
		{
			percentualAumento = 13;
			aumentoReal = (salario * percentualAumento) / 100;
			salarioNovo = salario + aumentoReal;


			Console.WriteLine("O salário do colaborador é é:" + salario);
			Console.WriteLine("O percentual é:" + percentualAumento);
			Console.WriteLine("O valor a se acrescentar é:" + aumentoReal);
			Console.WriteLine("O salário novo é:" + salarioNovo);


			conversaoDolar = salarioNovo / dolar;
			conversaoEuro = salarioNovo / euro;
			Console.WriteLine("O salário em dolar é:" + conversaoDolar);
			Console.WriteLine("O salário em euro é:" + conversaoEuro);
		}
		else if (salario > 2000 & salario <= 2500)
		{
			percentualAumento = 10;
			aumentoReal = (salario * percentualAumento) / 100;
			salarioNovo = salario + aumentoReal;


			Console.WriteLine("O salário do colaborador é é:" + salario);
			Console.WriteLine("O percentual é:" + percentualAumento);
			Console.WriteLine("O valor a se acrescentar é:" + aumentoReal);
			Console.WriteLine("O salário novo é:" + salarioNovo);

			conversaoDolar = salarioNovo / dolar;
			conversaoEuro = salarioNovo / euro;
			Console.WriteLine("O salário em dolar é:" + conversaoDolar);
			Console.WriteLine("O salário em euro é:" + conversaoEuro);
		}
		else if (salario > 2500)
		{
			percentualAumento = 5;
			aumentoReal = (salario * percentualAumento) / 100;
			salarioNovo = salario + aumentoReal;


			Console.WriteLine("O salário do colaborador é é:" + salario);
			Console.WriteLine("O percentual é:" + percentualAumento);
			Console.WriteLine("O valor a se acrescentar é:" + aumentoReal);
			Console.WriteLine("O salário novo é:" + salarioNovo);

			conversaoDolar = salarioNovo / dolar;
			conversaoEuro = salarioNovo / euro;
			Console.WriteLine("O salário em dolar é:" + conversaoDolar);
			Console.WriteLine("O salário em euro é:" + conversaoEuro);
		}

















	}
}