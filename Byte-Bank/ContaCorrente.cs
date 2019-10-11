using System;

namespace Byte_Bank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _Saldo;
        
        public double Saldo{
            get{return _Saldo;}
        }
        
        public ContaCorrente(int Agencia, int Numero, Cliente Titular)
        {
            this._Saldo = 0.0;
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
        }
        public double Deposito(double valor)
        {
                if (valor > 0)
                {
                    return this._Saldo += valor;
                    
                }else{
                    return 0;
                }

        }
        public bool Saque(double valor)
        {
            if(this._Saldo >= valor-){
                this._Saldo -= valor;
                return true;
            }else{
                return false;
            }
        }
        public bool Tranferencia(ContaCorrente contaDestino, double Valor){
                if (this.Saque(Valor))
                {
                    contaDestino.Deposito(Valor);
                    return true;
                } else {
                    return false;
                }
        }

    }
}