using System;

namespace Byte_Bank
{
    public class ContaCorrente
    {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public ContaCorrente(int Agencia, int Numero, string Titular)
        {
            this.Saldo = 0;
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
        }
        public double Deposito(double Dinheiro)
        {
            double SaldoAtual;
            System.Console.WriteLine("Escolha o valor que você quer Depositar.");
            Dinheiro = double.Parse(Console.ReadLine());

            if (Dinheiro > 0)
            {
                SaldoAtual = Dinheiro + Saldo;
                System.Console.WriteLine($"Seu saldo Atual é : {SaldoAtual} ");

                return SaldoAtual;
            }
            else
            {
                System.Console.WriteLine("Valor do deposito invalido!");
                return Saldo;
            }


        }
        public bool Saque(double Dinheiro)
        {
            double saque;
            do
            {
                System.Console.WriteLine("Escolha o valor que você quer Sacar:");
                Dinheiro = double.Parse(Console.ReadLine());
                if (Dinheiro <= Saldo)
                {
                    saque = Saldo - Dinheiro;
                    
                    System.Console.WriteLine($"Voce acabou de sacar {saque}");
                    return true;
                }
                else
                {
                    return false;
                }
            }while(Dinheiro > Saldo);
        }
        public bool Tranferencia(ContaCorrente contaDestino, double Valor){
                if (this.Saque(Valor))
                {
                    contaDestino.Deposito(valor);
                    return true;
                } else {
                    return false;
                }
        }

    }
}