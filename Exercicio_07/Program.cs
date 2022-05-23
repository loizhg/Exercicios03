using System;
namespace Luiz
{

    public class Program
    {
        public static void Main()
        {


            string[] usuario = new string[5];
            usuario[0] = "Luiz";
            usuario[1] = "Tales";
            usuario[2] = "Palu";
            usuario[3] = "Collato";
            usuario[4] = "Yuske";


            decimal[] contas = new decimal[5];
            contas[0] = 0100;
            contas[1] = 1000;
            contas[2] = 2000;
            contas[3] = 3000;
            contas[4] = 4000;


            int contaA_id;
            bool contaASelec = false;

            int contaB_id;
            bool contaBSelec = false;

            decimal opcaoT;
            decimal valor;

            decimal newValorA;
            decimal newValorB;





            // escolher primeira conta
            Console.WriteLine("Escolha um dos usuários a seguir baseado em seus ID's");
            Console.WriteLine("\t 0 - Luiz");
            Console.WriteLine("\t 1 - Tales");
            Console.WriteLine("\t 2 - Palu");
            Console.WriteLine("\t 3 - Collato");
            Console.WriteLine("\t 4 - Yuske");
            Console.Write("Sua opção? ");

            // mostrar qual conta o cara escolheu
            contaA_id = Convert.ToInt32(Console.ReadLine());
            switch (contaA_id)
            {
                case 0:
                    Console.WriteLine($"A conta selecionada foi a do Luiz");
                    break;
                case 1:
                    Console.WriteLine($"A conta selecionada foi a do Tales");
                    break;
                case 2:
                    Console.WriteLine($"A conta selecionada foi a do Palu");
                    break;
                case 3:
                    Console.WriteLine($"A conta selecionada foi a do Collato");
                    break;
                case 4:
                    Console.WriteLine($"A conta selecionada foi a do Yuske");
                    break;
            }
            contaASelec = true;


            // mostra as opções ao usuário
            Console.WriteLine("Escolha um dos usuários a seguir baseado em seus ID's");
            Console.WriteLine("\t 0 - Sacar");
            Console.WriteLine("\t 1 - Depositar");
            Console.WriteLine("\t 2 - Transferir");
            Console.WriteLine("\t 3 - Finalizar transação");
            Console.Write("Sua opção? ");

            // mostrar qual conta o cara escolheu
            opcaoT = Convert.ToDecimal(Console.ReadLine());

            while (opcaoT != 3)
            {

                switch (opcaoT)
                {
                    case 0:
                        Console.WriteLine($"Sua opção selecionada foi Saque");
                        break;
                    case 1:
                        Console.WriteLine($"Sua opção selecionada foi Deposito");
                        break;
                    case 2:
                        Console.WriteLine($"Sua opção selecionada foi Transferencia");
                        break;
                    case 3:
                        Console.WriteLine($"Você optou por cancelar transação");
                        break;
                }
                //checar se a opção foi para dar exit
                if (opcaoT == 3)
                {
                    System.Environment.Exit(0);
                }
                contaASelec = true;



                if (opcaoT == 0)
                {
                    valor = Convert.ToDecimal(Console.ReadLine());
                    newValorA = contas[contaA_id] - valor;
                    if (contas[contaA_id] < valor)
                    {
                        Console.WriteLine("Você não possui saldo o suficiente!");
                    }
                    else
                    {
                        Console.WriteLine("O saldo da conta A: pertence ao usuário " + usuario[contaA_id] + " o novo valor após o saque é:  " + newValorA);
                        contas[contaA_id] = newValorA;
                    }

                }
                if (opcaoT == 1)
                {
                    valor = Convert.ToDecimal(Console.ReadLine());
                    newValorA = contas[contaA_id] + valor;
                    Console.WriteLine("O saldo da conta A: pertence ao usuário " + usuario[contaA_id] + " o novo valor após o deposito é:  " + newValorA);
                    contas[contaA_id] = newValorA;
                }


                if (opcaoT == 2)
                {
                    // escolher a segunda conta
                    Console.WriteLine("Escolha um dos usuários a seguir para realizar a transferencia baseado em seus ID's");
                    Console.WriteLine("\t 0 - Luiz");
                    Console.WriteLine("\t 1 - Tales");
                    Console.WriteLine("\t 2 - Palu");
                    Console.WriteLine("\t 3 - Collato");
                    Console.WriteLine("\t 4 - Yuske");
                    Console.Write("Sua opção? ");

                    // mostrar qual conta o cara escolheu
                    contaB_id = Convert.ToInt32(Console.ReadLine());
                    switch (contaB_id)
                    {
                        case 0:
                            Console.WriteLine($"A conta selecionada foi a do Luiz");
                            break;
                        case 1:
                            Console.WriteLine($"A conta selecionada foi a do Tales");
                            break;
                        case 2:
                            Console.WriteLine($"A conta selecionada foi a do Palu");
                            break;
                        case 3:
                            Console.WriteLine($"A conta selecionada foi a do Collato");
                            break;
                        case 4:
                            Console.WriteLine($"A conta selecionada foi a do Yuske");
                            break;
                    }
                    contaBSelec = true;
                    if (contaASelec && contaBSelec)
                    {
                        Console.WriteLine("O saldo da conta A: pertence ao usuário " + usuario[contaA_id] + " e contem de saldo o valor:  " + contas[contaA_id]);
                        Console.WriteLine("O saldo da conta B: pertence ao usuário " + usuario[contaB_id] + " e contem de saldo o valor:  " + contas[contaB_id]);

                        Console.WriteLine("Quanto você gostaria de transferir? ");


                        int valorT = 0;
                        valorT = Convert.ToInt32(Console.ReadLine());

                        newValorA = contas[contaA_id] - valorT;
                        newValorB = contas[contaB_id] + valorT;
                        if (contas[contaA_id] < valorT)
                        {
                            Console.WriteLine("Você não possui saldo o suficiente!");
                        }
                        else
                        {
                            Console.WriteLine("O saldo da conta A: pertence ao usuário " + usuario[contaA_id] + " e contem de saldo o valor:  " + newValorA);
                            Console.WriteLine("O saldo da conta B: pertence ao usuário " + usuario[contaB_id] + " e contem de saldo o valor:  " + newValorB);
                            contas[contaA_id] = newValorA;
                            contas[contaB_id] = newValorB;
                        }
                    }
                }
                // mostra as opções ao usuário
                Console.WriteLine("Escolha um dos usuários a seguir baseado em seus ID's");
                Console.WriteLine("\t 0 - Sacar");
                Console.WriteLine("\t 1 - Depositar");
                Console.WriteLine("\t 2 - Transferir");
                Console.WriteLine("\t 3 - Finalizar transação");
                Console.Write("Sua opção? ");

                // mostrar qual conta o cara escolheu
                opcaoT = Convert.ToDecimal(Console.ReadLine());
            }



        }

    }
}
