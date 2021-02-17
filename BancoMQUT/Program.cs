using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMQUT
{
    class Program
    {
        static void Main(string[] args)
        {
            //algumas partes não entendi e deixei comentado 
            //são partes do codigo que tentei implementar e não funcionou, embora a linguagem tenha compilado.

            int c = 1, novaConta = 0, menu = 0, escolhaConta = 0;
            //Conta[] conta = new Conta[10];
            bool exit = true;
            Conta conta = new Conta {cliente = new Cliente {endereco = new Endereco { } } };
            do
            {
                Console.Clear();
                Console.WriteLine("<==Banco Mais Q um Tustão S.A.==>");
                Console.WriteLine("\nMenu");
                Console.WriteLine("1-)Criar nova conta: ");
                Console.WriteLine("2-)Fazer deposito: ");
                Console.WriteLine("3-)Fazer saque: ");
                Console.WriteLine("4-)Fazer transferencia: ");
                Console.WriteLine("5-)Saldo: ");
                Console.WriteLine("6-)Sair: ");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        do
                        {
                            //conta = new Conta[c];

                            Console.WriteLine("\n===Dados da Conta corrente===");
                            Console.WriteLine("Digite a agencia: ");
                            int agencia = int.Parse(Console.ReadLine());
                            Console.WriteLine("Conta n° " + c);
                            Console.WriteLine("Nome do titular: ");
                            string nomeCliente = Console.ReadLine();
                            Console.WriteLine("Cpf do titular: ");
                            string cpf = Console.ReadLine();
                            Console.WriteLine("\n===Dados do Endereço=== ");
                            Console.WriteLine("Logradouro: ");
                            string logradouro = Console.ReadLine();
                            Console.WriteLine("Numero: ");
                            int numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cidade: ");
                            string cidade = Console.ReadLine();
                            Console.WriteLine("Estado: ");
                            string estado = Console.ReadLine();
                            Console.WriteLine("CEP: ");
                            string cep = Console.ReadLine();

                            conta.Agencia = agencia;
                            conta.Numero = c;
                            conta.cliente.Nome = nomeCliente;
                            conta.cliente.Cpf = cpf;
                            conta.cliente.endereco.Logradouro = logradouro;
                            conta.cliente.endereco.Numero = numero;
                            conta.cliente.endereco.Cidade = cidade;
                            conta.cliente.endereco.Estado = estado;
                            conta.cliente.endereco.Cep = cep;

                            //conta[c].Agencia = agencia;
                            //conta[c].Numero = c;
                            //conta[c].cliente.Nome = nomeCliente;
                            //conta[c].cliente.Cpf = cpf;
                            c++;
                        }
                        while (novaConta == 1);
                        break;

                    case 2:

                        Console.WriteLine("Informe o numero da conta");
                        escolhaConta = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor do deposito");
                        double valor = double.Parse(Console.ReadLine());
                        string logDep = conta.deposito(valor);
                        Console.WriteLine(logDep);
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Informe o numero da conta: ");
                        escolhaConta = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor para saque: ");
                        valor = double.Parse(Console.ReadLine());
                        string logSaque = conta.saque(valor);
                        Console.WriteLine(logSaque);
                        Console.ReadKey();
                        break;

                    case 5:

                        Console.WriteLine(conta);
                        Console.ReadKey();
                        break;
                }
            }
            while (exit);
        }
    }
}