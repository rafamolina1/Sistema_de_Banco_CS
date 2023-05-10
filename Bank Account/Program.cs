using System;

class Program
{
    static void Main(string[] args)
    {
        decimal saldo = 0;


        while (true)
        {
            Console.WriteLine("O que você gostaria de fazer?");
            Console.WriteLine("1. Depositar o pix");
            Console.WriteLine("2. Sacar o pix");
            Console.WriteLine("3. Verificar o pix");
            Console.WriteLine("4. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite o valor que quer depositar:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal deposito))
                    {
                        if (deposito > 0)
                            saldo += deposito;
                        Console.WriteLine($"Depósito de {deposito:C} efetuado. Saldo atual: {saldo:C}");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }

                    break;

                case "2":
                    Console.WriteLine("Digite o valor que quer sacar:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal saque))
                    {
                        if (saque > saldo)
                        {
                            Console.WriteLine("Saldo insuficiente.");
                        }
                        else
                        {
                            if (saque > 0)
                                saldo -= saque;
                            Console.WriteLine($"Saque de {saque:C} efetuado com sucesso. Saldo atual: {saldo:C}");

                            //'':C'' é especificador de formato de string. ele formata o valor numerico como uma string usando config regional do sistema
                            //ou seja, se vc estiver no brasil, {saldo:C} vai representar o saldo em R$, se fosse nos EUA seria $.
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }

                    break;

                case "3":
                    Console.WriteLine($"Saldo atual: {saldo:C}");
                    break;

                case "4":
                    //Console.WriteLine("Obrigado.");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}