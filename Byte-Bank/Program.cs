﻿using System;

namespace Byte_Bank
{
    class Program
    {
        private const bool V = false;

        static void Main(string[] args)
        {
            System.Console.WriteLine("ByteBank - Cadastro de Clientes");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome, cpf, email);

            bool trocouSenha = false;
            do
            {
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if (trocouSenha)
                {
                    System.Console.WriteLine("Senha alterada com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("Senha Invalida!");
                }
            } while (!trocouSenha);

            System.Console.WriteLine("_________________________________");
            System.Console.WriteLine("    Dados da Conta Corrente");
            System.Console.WriteLine("_________________________________");
            Console.Write("Nome do Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Numero da Agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            Console.Write("Numero da Conta Corrente: ");
            int numero = int.Parse(Console.ReadLine());


            ContaCorrente contaCorrente1 = new ContaCorrente(numero, agencia, titular);
            double saldo;
            
            do{
                Console.Write("Saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if (saldo >= 0)
                {
                    System.Console.WriteLine("Sua conta foi cadastrada!");
                    contaCorrente1.Saldo =saldo;
                }
                else
                {
                    System.Console.WriteLine("Sua conta não foi cadastrada pois seu saldo é negativo!");
                }

            } while (saldo < 0);
            Console.WriteLine();
        }
    }
}

